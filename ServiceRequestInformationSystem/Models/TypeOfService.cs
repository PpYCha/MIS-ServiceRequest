using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class TypeOfService
    {
        public int TS_ID { get; set; }
        //public string TypeOfServiceProvided { get; set; }
        //public bool IsActive { get; set; }

        public int USER_ID { get; set; }
        public Account Account { get; set; }
        public ServiceRequestInfo ServiceRequestInfo { get; set; }
        public int SR_ID { get; set; }

        //     public ICollection<ServiceRequestInfo> ServiceRequestInfo { get; internal set; }
    }
}