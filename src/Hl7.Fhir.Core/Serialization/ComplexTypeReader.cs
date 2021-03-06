﻿/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Hl7.Fhir.Serialization
{
    internal class ComplexTypeReader
    {
        private IFhirReader _current;
        private ModelInspector _inspector;

        public ComplexTypeReader(IFhirReader reader)
        {
            _current = reader;
            _inspector = SerializationConfig.Inspector;
        }

        internal Base Deserialize(Type elementType, Base existing = null)
        {
            var mapping = _inspector.FindClassMappingByType(elementType);

            if (mapping == null)
                throw Error.Format("Asked to deserialize unknown type '" + elementType.Name + "'", _current);

            return Deserialize(mapping, existing);
        }
        
        internal Base Deserialize(ClassMapping mapping, Base existing=null)
        {
            if (mapping == null) throw Error.ArgumentNull("mapping");

            if (existing == null)
            {
                var fac = new DefaultModelFactory();
                existing = (Base)fac.Create(mapping.NativeType);
            }
            else
            {
                if (mapping.NativeType != existing.GetType())
                    throw Error.Argument("existing", "Existing instance is of type {0}, but data indicates resource is a {1}", existing.GetType().Name, mapping.NativeType.Name);
            }

            IEnumerable<Tuple<string, IFhirReader>> members = null;

            if (_current.CurrentToken == TokenType.Object)
            {
                members = _current.GetMembers();
            }
            else if(_current.IsPrimitive())
            {
                // Ok, we expected a complex type, but we found a primitive instead. This may happen
                // in Json where the value property and the other elements are separately put into
                // member and _member. In this case, we will parse the primitive into the Value property
                // of the complex type
                if (!mapping.HasPrimitiveValueMember)
                    throw Error.Format("Complex object does not have a value property, yet the reader is at a primitive", _current);

                // Simulate this as actually receiving a member "Value" in a normal complex object,
                // and resume normally
                var valueMember = Tuple.Create(mapping.PrimitiveValueProperty.Name, _current);
                members = new List<Tuple<string, IFhirReader>> { valueMember };
            }
            else
                throw Error.Format("Trying to read a complex object, but reader is not at the start of an object or primitive", _current);

            read(mapping, members, existing);

            return existing;

        }


        private void read(ClassMapping mapping, IEnumerable<Tuple<string,IFhirReader>> members, Base existing)
        {
            //bool hasMember;

            foreach (var memberData in members)
            {
                //hasMember = true;
                var memberName = memberData.Item1;  // tuple: first is name of member

                //if (memberName.StartsWith("http:"))
                //{
                //    // This is the special json-style extension
                //    var mappedProperty = mapping.FindMappedElementByName("extension");
                //    var value = (List<Extension>)mappedProperty.GetValue(existing);

                //    var reader = new DispatchingReader(memberData.Item2);
                //    value = (List<Extension>)reader.Deserialize(mappedProperty, "extension", value);

                //    foreach (var ext in value) ext.Url = memberName;
                //    mappedProperty.SetValue(existing, value);
                //}
                // Find a property on the instance that matches the element found in the data
                // NB: This function knows how to handle suffixed names (e.g. xxxxBoolean) (for choice types).
                var mappedProperty = mapping.FindMappedElementByName(memberName);

                if (mappedProperty != null)
                {
                    //   Message.Info("Handling member {0}.{1}", mapping.Name, memberName);

                    object value = null;

                    // For primitive members we can save time by not calling the getter
                    if (!mappedProperty.IsPrimitive)
                        value = mappedProperty.GetValue(existing);

                    var reader = new DispatchingReader(memberData.Item2);
                    value = reader.Deserialize(mappedProperty, memberName, value);

                    mappedProperty.SetValue(existing, value);
                }
                else
                {
                    if (SerializationConfig.AcceptUnknownMembers == false)
                        throw Error.Format("Encountered unknown member '{0}' while deserializing", _current, memberName);
                    else
                        Message.Info("Skipping unknown member " + memberName);
                }
            }

        }
    }
}
