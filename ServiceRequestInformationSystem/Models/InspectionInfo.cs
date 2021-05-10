using System;
using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class InspectionInfo
    {
        public int II_ID { get;  set; }
        public string RequestingOffice { get; set; }
        public string RequestedBy { get; set; }
        public string ReceiveBy { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string TypeOfUnit { get; set; }
        public string ComplaintOnUnit { get; set; }
        public string PropertyNumber { get; set; }
        public string Position { get; set; }

        public ICollection<ProcedureTest> ProcedureTest { get; internal set; }
        public ICollection<FindingParticular> FindingParticular { get; internal set; }
        public ICollection<Recommendation> Recommendation { get; internal set; }
        public ICollection<UnitSpecification> UnitSpecification { get; internal set; }
        public ICollection<InspectedPerformedBy> InspectedPerformedBy { get; internal set; }
    }
}