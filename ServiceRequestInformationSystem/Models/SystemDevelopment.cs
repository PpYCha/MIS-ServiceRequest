using System;

namespace ServiceRequestInformationSystem.Models
{
    public class SystemDevelopment
    {
        public int SD_ID { get; set; }
        public int USER_ID { get; set; }
        public DateTime? DateAccomplishment { get; set; }
        public string Remarks { get; set; }
        public string Accomplishment { get; set; }
        public bool WeeklyMonthly { get; set; }
        public string SystemTitle { get; set; }
        public Account Account { get; set; }
    }
}