namespace ServiceRequestInformationSystem.Models
{
    public class Recommendation
    {
        public int R_ID { get;  set; }
        public string RecommendationDetails { get; set; }
        public InspectionInfo InspectionInfo { get; internal set; }
        public int? II_ID { get; internal set; }
    }
}