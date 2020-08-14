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
            string strServer = "tcp:192.168.0.100,49172";
            string strUserName = "miso_server";
            string strPassword = "miso4321";
            string strDatabaseName = "SrisDb";

            crystalReportViewer1.SelectionFormula = "monthname(month({ SystemDevelopments.DateAccomplishment})) LIKE '" + ucSystemDevWeekly.printMonth + "'";




            rpt_Programmer_Weekly rpt_Programmer_Weekly = new rpt_Programmer_Weekly();
            rpt_Programmer_Weekly.DataSourceConnections[0].SetConnection(strServer, strDatabaseName, strUserName, strPassword);

            rpt_Programmer_Weekly.SetParameterValue("UserID", WelcomeForm.AccountID);
            rpt_Programmer_Weekly.SetParameterValue("Month", ucSystemDevWeekly.printMonth);
            crystalReportViewer1.ReportSource = rpt_Programmer_Weekly;

        }
    }
}
