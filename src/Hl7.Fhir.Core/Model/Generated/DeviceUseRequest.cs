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
    /// Request for device use
    /// </summary>
    [FhirType("DeviceUseRequest", IsResource=true)]
    [DataContract]
    public partial class DeviceUseRequest : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DeviceUseRequest; } }
        [NotMapped]
        public override string TypeName { get { return "DeviceUseRequest"; } }
        
        /// <summary>
        /// Codes representing the status of the request
        /// </summary>
        [FhirEnumeration("DeviceUseRequestStatus")]
        public enum DeviceUseRequestStatus
        {
            /// <summary>
            /// The request has been proposed.
            /// </summary>
            [EnumLiteral("proposed")]
            Proposed,
            /// <summary>
            /// The request has been planned.
            /// </summary>
            [EnumLiteral("planned")]
            Planned,
            /// <summary>
            /// The request has been placed.
            /// </summary>
            [EnumLiteral("requested")]
            Requested,
            /// <summary>
            /// The receiving system has received the request but not yet decided whether it will be performed.
            /// </summary>
            [EnumLiteral("received")]
            Received,
            /// <summary>
            /// The receiving system has accepted the request but work has not yet commenced.
            /// </summary>
            [EnumLiteral("accepted")]
            Accepted,
            /// <summary>
            /// The work to fulfill the order is happening.
            /// </summary>
            [EnumLiteral("in progress")]
            InProgress,
            /// <summary>
            /// The work has been complete, the report(s) released, and no further work is planned.
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// The request has been held by originating system/user request.
            /// </summary>
            [EnumLiteral("suspended")]
            Suspended,
            /// <summary>
            /// The receiving system has declined to fulfill the request.
            /// </summary>
            [EnumLiteral("rejected")]
            Rejected,
            /// <summary>
            /// The request was attempted, but due to some procedural error, it could not be completed.
            /// </summary>
            [EnumLiteral("aborted")]
            Aborted,
        }
        
        /// <summary>
        /// Codes representing the priority of the request
        /// </summary>
        [FhirEnumeration("DeviceUseRequestPriority")]
        public enum DeviceUseRequestPriority
        {
            /// <summary>
            /// The request has a normal priority.
            /// </summary>
            [EnumLiteral("routine")]
            Routine,
            /// <summary>
            /// The request should be done urgently.
            /// </summary>
            [EnumLiteral("urgent")]
            Urgent,
            /// <summary>
            /// The request is time-critical.
            /// </summary>
            [EnumLiteral("stat")]
            Stat,
            /// <summary>
            /// The request should be acted on as soon as possible.
            /// </summary>
            [EnumLiteral("asap")]
            Asap,
        }
        
        /// <summary>
        /// Target body site
        /// </summary>
        [FhirElement("bodySite", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> BodySite
        {
            get { if(_BodySite==null) _BodySite = new List<Hl7.Fhir.Model.CodeableConcept>(); return _BodySite; }
            set { _BodySite = value; OnPropertyChanged("BodySite"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _BodySite;
        
        /// <summary>
        /// proposed | planned | requested | received | accepted | in progress | completed | suspended | rejected | aborted
        /// </summary>
        [FhirElement("status", Order=100)]
        [DataMember]
        public Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestStatus> _StatusElement;
        
        /// <summary>
        /// proposed | planned | requested | received | accepted | in progress | completed | suspended | rejected | aborted
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Device requested
        /// </summary>
        [FhirElement("device", Order=110)]
        [References("Device")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Device
        {
            get { return _Device; }
            set { _Device = value; OnPropertyChanged("Device"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Device;
        
        /// <summary>
        /// Encounter motivating request
        /// </summary>
        [FhirElement("encounter", Order=120)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Request identifier
        /// </summary>
        [FhirElement("identifier", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Reason for request
        /// </summary>
        [FhirElement("indication", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Indication
        {
            get { if(_Indication==null) _Indication = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Indication; }
            set { _Indication = value; OnPropertyChanged("Indication"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Indication;
        
        /// <summary>
        /// Notes or comments
        /// </summary>
        [FhirElement("notes", Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> NotesElement
        {
            get { if(_NotesElement==null) _NotesElement = new List<Hl7.Fhir.Model.FhirString>(); return _NotesElement; }
            set { _NotesElement = value; OnPropertyChanged("NotesElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _NotesElement;
        
        /// <summary>
        /// Notes or comments
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Notes
        {
            get { return NotesElement != null ? NotesElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  NotesElement = null; 
                else
                  NotesElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("Notes");
            }
        }
        
        /// <summary>
        /// PRN
        /// </summary>
        [FhirElement("prnReason", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> PrnReason
        {
            get { if(_PrnReason==null) _PrnReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _PrnReason; }
            set { _PrnReason = value; OnPropertyChanged("PrnReason"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _PrnReason;
        
        /// <summary>
        /// When ordered
        /// </summary>
        [FhirElement("orderedOn", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime OrderedOnElement
        {
            get { return _OrderedOnElement; }
            set { _OrderedOnElement = value; OnPropertyChanged("OrderedOnElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _OrderedOnElement;
        
        /// <summary>
        /// When ordered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string OrderedOn
        {
            get { return OrderedOnElement != null ? OrderedOnElement.Value : null; }
            set
            {
                if(value == null)
                  OrderedOnElement = null; 
                else
                  OrderedOnElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("OrderedOn");
            }
        }
        
        /// <summary>
        /// When recorded
        /// </summary>
        [FhirElement("recordedOn", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime RecordedOnElement
        {
            get { return _RecordedOnElement; }
            set { _RecordedOnElement = value; OnPropertyChanged("RecordedOnElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _RecordedOnElement;
        
        /// <summary>
        /// When recorded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string RecordedOn
        {
            get { return RecordedOnElement != null ? RecordedOnElement.Value : null; }
            set
            {
                if(value == null)
                  RecordedOnElement = null; 
                else
                  RecordedOnElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("RecordedOn");
            }
        }
        
        /// <summary>
        /// Focus of request
        /// </summary>
        [FhirElement("subject", Order=190)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// Schedule for use
        /// </summary>
        [FhirElement("timing", Order=200, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Timing),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.FhirDateTime))]
        [DataMember]
        public Hl7.Fhir.Model.Element Timing
        {
            get { return _Timing; }
            set { _Timing = value; OnPropertyChanged("Timing"); }
        }
        
        private Hl7.Fhir.Model.Element _Timing;
        
        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        [FhirElement("priority", Order=210)]
        [DataMember]
        public Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestPriority> PriorityElement
        {
            get { return _PriorityElement; }
            set { _PriorityElement = value; OnPropertyChanged("PriorityElement"); }
        }
        
        private Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestPriority> _PriorityElement;
        
        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if(value == null)
                  PriorityElement = null; 
                else
                  PriorityElement = new Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DeviceUseRequest;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(BodySite != null) dest.BodySite = new List<Hl7.Fhir.Model.CodeableConcept>(BodySite.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestStatus>)StatusElement.DeepCopy();
                if(Device != null) dest.Device = (Hl7.Fhir.Model.ResourceReference)Device.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Indication != null) dest.Indication = new List<Hl7.Fhir.Model.CodeableConcept>(Indication.DeepCopy());
                if(NotesElement != null) dest.NotesElement = new List<Hl7.Fhir.Model.FhirString>(NotesElement.DeepCopy());
                if(PrnReason != null) dest.PrnReason = new List<Hl7.Fhir.Model.CodeableConcept>(PrnReason.DeepCopy());
                if(OrderedOnElement != null) dest.OrderedOnElement = (Hl7.Fhir.Model.FhirDateTime)OrderedOnElement.DeepCopy();
                if(RecordedOnElement != null) dest.RecordedOnElement = (Hl7.Fhir.Model.FhirDateTime)RecordedOnElement.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(Timing != null) dest.Timing = (Hl7.Fhir.Model.Element)Timing.DeepCopy();
                if(PriorityElement != null) dest.PriorityElement = (Code<Hl7.Fhir.Model.DeviceUseRequest.DeviceUseRequestPriority>)PriorityElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new DeviceUseRequest());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DeviceUseRequest;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Device, otherT.Device)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if( !DeepComparable.Matches(NotesElement, otherT.NotesElement)) return false;
            if( !DeepComparable.Matches(PrnReason, otherT.PrnReason)) return false;
            if( !DeepComparable.Matches(OrderedOnElement, otherT.OrderedOnElement)) return false;
            if( !DeepComparable.Matches(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if( !DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DeviceUseRequest;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if( !DeepComparable.IsExactly(NotesElement, otherT.NotesElement)) return false;
            if( !DeepComparable.IsExactly(PrnReason, otherT.PrnReason)) return false;
            if( !DeepComparable.IsExactly(OrderedOnElement, otherT.OrderedOnElement)) return false;
            if( !DeepComparable.IsExactly(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if( !DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            
            return true;
        }
        
    }
    
}
