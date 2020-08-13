using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class Account
    {
        public int USER_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AccessLevel { get; set; }
        public bool IsActive { get; set; }
        public bool IsLogOn { get; set; }

        public ICollection<TechnicianRequest> TechnicianRequest { get; set; }
        public ICollection<TypeOfService> TypeOfServices { get; set; }
        public ICollection<SystemDevelopment> SystemDevelopment { get; internal set; }
    }
}