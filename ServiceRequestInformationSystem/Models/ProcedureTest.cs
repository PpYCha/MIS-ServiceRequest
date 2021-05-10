namespace ServiceRequestInformationSystem.Models
{
    public class ProcedureTest
    {
        public int PT_ID { get;  set; }
        public string ProcedureTestDetails { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}