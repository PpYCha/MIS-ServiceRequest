using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ServiceRequestInformationSystem
{
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();





            metroComboBox1.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                                                     .MonthNames.Take(12).ToList();
            metroComboBox1.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames[DateTime.Now.AddMonths(-1).Month - 1];

            metroComboBox2.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            metroComboBox2.SelectedItem = DateTime.Now.Year;

           


        }

        private static ucReports _instance;
        public static ucReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucReports();
                return _instance;
            }
        }

        private void bt_MonthlyReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var month = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
            var year = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);

            crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequestInfoes.DateAccomplished})) Like '*" + month + "*'" + " AND " + "Year({ServiceRequestInfoes.DateAccomplished})= " + year + "";
            //crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequestInfoes.DateAccomplished})) Like '*" + month + "*'";
            rpt_Monthly report1 = new rpt_Monthly();

            report1.SetParameterValue("MonthLabel", month);

            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;
        }


    }
}
