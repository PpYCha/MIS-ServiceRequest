namespace ServiceRequestInformationSystem.Models
{
    public class UnitSpecification
    {
        public int US_ID { get;  set; }
        public string HardwareComponent { get; set; }
        public string Remarks { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}