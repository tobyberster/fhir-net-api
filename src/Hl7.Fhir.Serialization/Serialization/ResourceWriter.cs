﻿using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Properties;
using Hl7.Fhir.Support;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Hl7.Fhir.Serialization
{
    public class ResourceWriter
    {       
        private IFhirWriter _writer;
        private ModelInspector _inspector;

        public ResourceWriter(IFhirWriter writer)
        {
            _writer = writer;
            _inspector = SerializationConfig.Inspector;
        }

        public void Serialize(object instance)
        {
            if (instance == null) throw Error.ArgumentNull("instance");

            var mapping = _inspector.ImportType(instance.GetType());

            _writer.WriteStartRootObject(mapping.Name);

            var complexSerializer = new ComplexTypeWriter(_writer, forResource: true);
            complexSerializer.Serialize(mapping, instance);

            _writer.WriteEndRootObject();
        }
    }
}