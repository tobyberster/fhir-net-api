﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Wed, Dec 24, 2014 16:02+0100 for FHIR v0.4.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Potential outcomes for a subject with likelihood
    /// </summary>
    [FhirType("RiskAssessment", IsResource=true)]
    [DataContract]
    public partial class RiskAssessment : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.RiskAssessment; } }
        [NotMapped]
        public override string TypeName { get { return "RiskAssessment"; } }
        
        [FhirType("RiskAssessmentPredictionComponent")]
        [DataContract]
        public partial class RiskAssessmentPredictionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RiskAssessmentPredictionComponent"; } }
            
            /// <summary>
            /// Possible outcome for the subject
            /// </summary>
            [FhirElement("outcome", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Outcome
            {
                get { return _Outcome; }
                set { _Outcome = value; OnPropertyChanged("Outcome"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Outcome;
            
            /// <summary>
            /// Likelihood of specified outcome
            /// </summary>
            [FhirElement("probability", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDecimal),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element Probability
            {
                get { return _Probability; }
                set { _Probability = value; OnPropertyChanged("Probability"); }
            }
            
            private Hl7.Fhir.Model.Element _Probability;
            
            /// <summary>
            /// Relative likelihood
            /// </summary>
            [FhirElement("relativeRisk", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal RelativeRiskElement
            {
                get { return _RelativeRiskElement; }
                set { _RelativeRiskElement = value; OnPropertyChanged("RelativeRiskElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _RelativeRiskElement;
            
            /// <summary>
            /// Relative likelihood
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? RelativeRisk
            {
                get { return RelativeRiskElement != null ? RelativeRiskElement.Value : null; }
                set
                {
                    if(value == null)
                      RelativeRiskElement = null; 
                    else
                      RelativeRiskElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("RelativeRisk");
                }
            }
            
            /// <summary>
            /// Timeframe or age range
            /// </summary>
            [FhirElement("when", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range))]
            [DataMember]
            public Hl7.Fhir.Model.Element When
            {
                get { return _When; }
                set { _When = value; OnPropertyChanged("When"); }
            }
            
            private Hl7.Fhir.Model.Element _When;
            
            /// <summary>
            /// Explanation of prediction
            /// </summary>
            [FhirElement("rationale", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RationaleElement
            {
                get { return _RationaleElement; }
                set { _RationaleElement = value; OnPropertyChanged("RationaleElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RationaleElement;
            
            /// <summary>
            /// Explanation of prediction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Rationale
            {
                get { return RationaleElement != null ? RationaleElement.Value : null; }
                set
                {
                    if(value == null)
                      RationaleElement = null; 
                    else
                      RationaleElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Rationale");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RiskAssessmentPredictionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Outcome != null) dest.Outcome = (Hl7.Fhir.Model.CodeableConcept)Outcome.DeepCopy();
                    if(Probability != null) dest.Probability = (Hl7.Fhir.Model.Element)Probability.DeepCopy();
                    if(RelativeRiskElement != null) dest.RelativeRiskElement = (Hl7.Fhir.Model.FhirDecimal)RelativeRiskElement.DeepCopy();
                    if(When != null) dest.When = (Hl7.Fhir.Model.Element)When.DeepCopy();
                    if(RationaleElement != null) dest.RationaleElement = (Hl7.Fhir.Model.FhirString)RationaleElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RiskAssessmentPredictionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RiskAssessmentPredictionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
                if( !DeepComparable.Matches(Probability, otherT.Probability)) return false;
                if( !DeepComparable.Matches(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
                if( !DeepComparable.Matches(When, otherT.When)) return false;
                if( !DeepComparable.Matches(RationaleElement, otherT.RationaleElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RiskAssessmentPredictionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
                if( !DeepComparable.IsExactly(Probability, otherT.Probability)) return false;
                if( !DeepComparable.IsExactly(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
                if( !DeepComparable.IsExactly(When, otherT.When)) return false;
                if( !DeepComparable.IsExactly(RationaleElement, otherT.RationaleElement)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Who/what does assessment apply to?
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=90)]
        [References("Patient","Group")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// When was assessment made?
        /// </summary>
        [FhirElement("date", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// When was assessment made?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Condition assessed
        /// </summary>
        [FhirElement("condition", InSummary=true, Order=110)]
        [References("Condition")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Condition
        {
            get { return _Condition; }
            set { _Condition = value; OnPropertyChanged("Condition"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Condition;
        
        /// <summary>
        /// Who did assessment?
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=120)]
        [References("Practitioner","Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Performer
        {
            get { return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Performer;
        
        /// <summary>
        /// Unique identifier for the assessment
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// Evaluation mechanism
        /// </summary>
        [FhirElement("method", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Method
        {
            get { return _Method; }
            set { _Method = value; OnPropertyChanged("Method"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Method;
        
        /// <summary>
        /// Information used in assessment
        /// </summary>
        [FhirElement("basis", Order=150)]
        [References()]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Basis
        {
            get { if(_Basis==null) _Basis = new List<Hl7.Fhir.Model.ResourceReference>(); return _Basis; }
            set { _Basis = value; OnPropertyChanged("Basis"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Basis;
        
        /// <summary>
        /// Outcome predicted
        /// </summary>
        [FhirElement("prediction", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.RiskAssessment.RiskAssessmentPredictionComponent> Prediction
        {
            get { if(_Prediction==null) _Prediction = new List<Hl7.Fhir.Model.RiskAssessment.RiskAssessmentPredictionComponent>(); return _Prediction; }
            set { _Prediction = value; OnPropertyChanged("Prediction"); }
        }
        
        private List<Hl7.Fhir.Model.RiskAssessment.RiskAssessmentPredictionComponent> _Prediction;
        
        /// <summary>
        /// How to reduce risk
        /// </summary>
        [FhirElement("mitigation", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString MitigationElement
        {
            get { return _MitigationElement; }
            set { _MitigationElement = value; OnPropertyChanged("MitigationElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _MitigationElement;
        
        /// <summary>
        /// How to reduce risk
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Mitigation
        {
            get { return MitigationElement != null ? MitigationElement.Value : null; }
            set
            {
                if(value == null)
                  MitigationElement = null; 
                else
                  MitigationElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Mitigation");
            }
        }
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RiskAssessment;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Condition != null) dest.Condition = (Hl7.Fhir.Model.ResourceReference)Condition.DeepCopy();
                if(Performer != null) dest.Performer = (Hl7.Fhir.Model.ResourceReference)Performer.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
                if(Basis != null) dest.Basis = new List<Hl7.Fhir.Model.ResourceReference>(Basis.DeepCopy());
                if(Prediction != null) dest.Prediction = new List<Hl7.Fhir.Model.RiskAssessment.RiskAssessmentPredictionComponent>(Prediction.DeepCopy());
                if(MitigationElement != null) dest.MitigationElement = (Hl7.Fhir.Model.FhirString)MitigationElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new RiskAssessment());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as RiskAssessment;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Condition, otherT.Condition)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Method, otherT.Method)) return false;
            if( !DeepComparable.Matches(Basis, otherT.Basis)) return false;
            if( !DeepComparable.Matches(Prediction, otherT.Prediction)) return false;
            if( !DeepComparable.Matches(MitigationElement, otherT.MitigationElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RiskAssessment;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if( !DeepComparable.IsExactly(Basis, otherT.Basis)) return false;
            if( !DeepComparable.IsExactly(Prediction, otherT.Prediction)) return false;
            if( !DeepComparable.IsExactly(MitigationElement, otherT.MitigationElement)) return false;
            
            return true;
        }
        
    }
    
}
