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
    public partial class DeveloperReportForm : Form
    {
        public DeveloperReportForm()
        {
            InitializeComponent();
        }

        private void DeveloperReportForm_Load(object sender, EventArgs e)
        {
            //string strServer = "tcp:192.168.1.100,49172";
            //string strUserName = "miso_server";
            //string strPassword = "miso4321";
            //string strDatabaseName = "SrisDb";

            // crystalReportViewer1.SelectionFormula = "monthname(month({ SystemDevelopments.DateAccomplishment})) LIKE '" + ucSystemDevWeekly.printMonth + "'";

            if (MainForm.accessLevel.Contains("ADMIN"))
            {
                rpt_Programmer_Weekly rpt_Programmer_Weekly = new rpt_Programmer_Weekly();
                rpt_Programmer_Weekly.DataSourceConnections[0].SetConnection(CrystalReportConnection.strServer, CrystalReportConnection.strDatabase, CrystalReportConnection.strUserId, CrystalReportConnection.strPwd);

                rpt_Programmer_Weekly.SetParameterValue("UserID", ucSystemDevAdmin.titleId);
                rpt_Programmer_Weekly.SetParameterValue("monthName", ucSystemDevWeekly.printMonth);

                DateTime date = DateTime.Parse("01" + ucSystemDevWeekly.printMonth + ucSystemDevWeekly.printYear);
                var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                ParameterRangeValue myParameterRangeValue = new ParameterRangeValue();
                myParameterRangeValue.StartValue = firstDayOfMonth;
                myParameterRangeValue.EndValue = lastDayOfMonth;
                rpt_Programmer_Weekly.SetParameterValue("Month", myParameterRangeValue);


                crystalReportViewer1.ReportSource = rpt_Programmer_Weekly;
            }


            if (MainForm.accessLevel.Contains("PROGRAMMER"))
            {
                rpt_Programmer_Weekly rpt_Programmer_Weekly = new rpt_Programmer_Weekly();
                // rpt_Programmer_Weekly.DataSourceConnections[0].SetConnection(CrystalReportConnection.strServer, CrystalReportConnection.strDatabase, CrystalReportConnection.strUserId, CrystalReportConnection.strPwd, true);
                rpt_Programmer_Weekly.DataSourceConnections[0].SetConnection(CrystalReportConnection.strServer, CrystalReportConnection.strDatabase, true);

                rpt_Programmer_Weekly.SetParameterValue("UserID", WelcomeForm.AccountID);
                rpt_Programmer_Weekly.SetParameterValue("monthName", ucSystemDevWeekly.printMonth);
                rpt_Programmer_Weekly.SetParameterValue("SystemTitle", ucSystemDevWeekly.PrintSystemTitle);

                DateTime date = DateTime.Parse("01" + ucSystemDevWeekly.printMonth + ucSystemDevWeekly.printYear);
                var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                ParameterRangeValue myParameterRangeValue = new ParameterRangeValue();
                myParameterRangeValue.StartValue = firstDayOfMonth;
                myParameterRangeValue.EndValue = lastDayOfMonth;
                rpt_Programmer_Weekly.SetParameterValue("Month", myParameterRangeValue);


                crystalReportViewer1.ReportSource = rpt_Programmer_Weekly;
            }
        }
    }
}
