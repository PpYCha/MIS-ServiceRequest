namespace ServiceRequestInformationSystem.Models
{
    public class FindingParticular
    {
        public int FP_ID { get;  set; }
        public string Particulars { get; set; }
        public string Status { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}