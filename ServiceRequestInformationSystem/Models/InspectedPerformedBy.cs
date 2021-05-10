namespace ServiceRequestInformationSystem.Models
{
    public class InspectedPerformedBy
    {
        public int IP_ID { get;  set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}