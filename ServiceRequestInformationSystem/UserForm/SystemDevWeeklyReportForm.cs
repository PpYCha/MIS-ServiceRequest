using CrystalDecisions.Shared;
using ServiceRequestInformationSystem.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem.UserForm
{
    public partial class SystemDevWeeklyReportForm : Form
    {
        public SystemDevWeeklyReportForm()
        {
            InitializeComponent();
        }

        private void SystemDevWeeklyReportForm_Load(object sender, EventArgs e)
        {
            if (MainForm.accessLevel.Contains("PROGRAMMER"))
            {
                rpt_SystemDevWeekly rpt_SystemDevWeekly = new rpt_SystemDevWeekly();
                // rpt_SystemDevWeekly.DataSourceConnections[0].SetConnection(CrystalReportConnection.strServer, CrystalReportConnection.strDatabase, CrystalReportConnection.strUserId, CrystalReportConnection.strPwd, true);
                rpt_SystemDevWeekly.DataSourceConnections[0].SetConnection(CrystalReportConnection.strServer, CrystalReportConnection.strDatabase, true);

                rpt_SystemDevWeekly.SetParameterValue("UserID", WelcomeForm.AccountID);
                //rpt_SystemDevWeekly.SetParameterValue("monthName", ucSystemDevWeekly.printMonth);


                //DateTime date = DateTime.Parse("01" + ucSystemDevWeekly.printMonth + ucSystemDevWeekly.printYear);
                //var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                //var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                //ParameterRangeValue myParameterRangeValue = new ParameterRangeValue();
                //myParameterRangeValue.StartValue = firstDayOfMonth;
                //myParameterRangeValue.EndValue = lastDayOfMonth;
                //rpt_SystemDevWeekly.SetParameterValue("Month", myParameterRangeValue);


                crystalReportViewer1.ReportSource = rpt_SystemDevWeekly;
            }
        }
    }
}
