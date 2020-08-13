using System;
using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class ServiceRequestInfo
    {
        public int SR_ID { get; set; }
        public string TypeOfServiceProvided { get; set; }
        public string RequestedBy { get; set; }
        public string OfficeDepartmentName { get; set; }
        public DateTime? DateRequested { get; set; }
        public string TimeLeft { get; set; }
        public DateTime? DateAccomplished { get; set; }

        public Boolean Status { get; set; }
        public string Techinicians { get; set; }
        public string RemarkDeatails { get; set; }
        public DateTime? DateEntered { get; set; }
        public string AssignedTechnician { get; set; }

        public ICollection<TechnicianRequest> TechnicianRequest { get; set; }
        public ICollection<TypeOfService> TypeOfServices { get; set; }
    }
}