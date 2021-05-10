using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class ServiceProvidedBy
    {
        public int SP_ID { get; set; }
        public string spName { get; set; }

        public string spPosition { get; set; }
        public bool IsActive { get; set; }


        public ICollection<TechnicianRequest> TechnicianRequest { get; set; }
    }
}