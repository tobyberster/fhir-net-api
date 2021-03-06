﻿/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.IO;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.Specification.Source
{
    public interface IArtifactSource
    {
        Stream ReadContentArtifact(string name);
        IEnumerable<string> ListArtifactNames();

        Hl7.Fhir.Model.Resource ReadConformanceResource(string identifier);
        IEnumerable<ConformanceInformation> ListConformanceResources();
    }


    public class ConformanceInformation
    {
        public string Identifier { get; set; }

        public ResourceType Type { get; set; }
                
        public string Name { get; set; }

        public string Origin { get; set; }

        public override string ToString()
        {
            return String.Format("{0} resource with id {1} ({2}), read from {3}", Type.ToString(), Identifier, Name, Origin);
        }
    }
}
