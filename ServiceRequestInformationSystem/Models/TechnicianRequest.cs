namespace ServiceRequestInformationSystem.Models
{
    public class TechnicianRequest
    {
        public int TR_ID { get; internal set; }
        public int SP_ID { get; set; }
        public ServiceProvidedBy ServiceProvidedBy { get; internal set; }
        public ServiceRequestInfo ServiceRequestInfo { get; internal set; }
        public int SR_ID { get; internal set; }
    }
}