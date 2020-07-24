using System;
using System.Collections.Generic;

namespace ServiceRequestInformationSystem.Models
{
    public class ServiceRequestInfo
    {
        public int SR_ID { get; set; }
        //   public int TS_ID { get; set; }
        public string TypeOfServiceProvided { get; set; }
        public string RequestedBy { get; set; }
        //  public int OD_ID { get; internal set; }
        public string OfficeDepartmentName { get; set; }
        public DateTime? DateRequested { get; set; }
        public string TimeLeft { get; set; }
        public DateTime? DateAccomplished { get; set; }

      //  public int Remark_ID { get; set; }
        public Boolean Status { get; set; }
        public string Techinicians { get; set; }
        public string RemarkDeatails { get; set; }
        public DateTime? DateEntered { get; set; }
        //  public TypeOfService TypeOfService { get; set; }

        //   public OfficeDepartment OfficeDepartment { get; set; }



        //  public RemarkInfo RemarkInfo { get; internal set; }
        public ICollection<TechnicianRequest> TechnicianRequest { get; internal set; }
    }
}