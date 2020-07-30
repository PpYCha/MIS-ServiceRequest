namespace ServiceRequestInformationSystem.Models
{
    public class TechnicianRequest
    {
        public int TR_ID { get; set; }
        public int USER_ID { get; set; }
        public Account Account { get;  set; }
        public ServiceRequestInfo ServiceRequestInfo { get;  set; }
        public int SR_ID { get;  set; }
    }
}