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
using ServiceRequestInformationSystem.Report;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

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
            //Cursor.Current = Cursors.WaitCursor;

            //string strServer = "tcp:192.168.0.100,49172";
            //string strDatabase = "SrisDb";
            //string strUserId = "miso_server";
            //string strPwd = "miso4321";

            //var month = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
            //var year = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);

            //crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequestInfoes.DateAccomplished})) Like '*" + month + "*'" + " AND " + "Year({ServiceRequestInfoes.DateAccomplished})= " + year + "";
            ////crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequestInfoes.DateAccomplished})) Like '*" + month + "*'";
            //rpt_Monthly report1 = new rpt_Monthly();
            //report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, strUserId, strPwd);
            //report1.SetParameterValue("MonthLabel", month);

            //crystalReportViewer1.ShowPrintButton = true;
            //crystalReportViewer1.ShowExportButton = true;
            //crystalReportViewer1.ReportSource = report1;
            //Cursor.Current = Cursors.Default;

            CrystalReport1();
        }

        private void CrystalReport1()
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDb";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;

            var month = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
            var year = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
            string desktopRepairCount = "DESKTOP";
            string laptopRepairCount = "LAPTOP";
            string printerRepairCount = "PRINTER";
            string netWorkConnectivityRepairCount = "NETWORK";
            string othersRepair = string.Empty;


            crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequestInfoes.DateAccomplished})) Like '*" + month + "*'" + " AND " +
                                                    "Year({ServiceRequestInfoes.DateAccomplished})= " + year +
                                                    " AND {ServiceRequestInfoes.Status} = True";


            

            string drCount = GetCount(desktopRepairCount, month, year);
            string lrCount = GetCount(laptopRepairCount, month, year);
            string prCount = GetCount(printerRepairCount, month, year);
            string nrCOunt = GetCount(netWorkConnectivityRepairCount, month, year);
            string orCOunt = GetOthers(othersRepair, month, year);


            rpt_Monthly_Technicians report1 = new rpt_Monthly_Technicians();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
            report1.SetParameterValue("MonthLabel", month + ", " + year);
            report1.SetParameterValue("DesktopRepair", drCount);
            report1.SetParameterValue("LaptopRepair", lrCount);
            report1.SetParameterValue("PrinterRepair", prCount);
            report1.SetParameterValue("NetWorkConnectivityRepairCount", nrCOunt);
            report1.SetParameterValue("OthersRepair", orCOunt);
            // report1.SetParameterValue("param_year", year);
           
            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;
        }

        private string GetCount(string count, string month, string year)
        {
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT * from ServiceRequestInfoes where TypeOfServiceProvided like @1 and MONTH(DateAccomplished) = @2 and YEAR(DateAccomplished) = @3 ", SQLCon.sqlConnection);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", "%" + count + "%");
            int a = (Convert.ToDateTime(month + " 01, 1900").Month);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@2", a);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@3", Int32.Parse(year));



            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);

            int i = 0;
            foreach (DataRow row in SQLCon.dataTable.Rows)
            {
                i++;
            }

            string number;
            number = i.ToString();

            return number;


        }

        private string GetOthers(string count, string month, string year)
        {
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT * from ServiceRequestInfoes where NOT TypeOfServiceProvided like '%DESKTOP%' and 
                                                    NOT TypeOfServiceProvided like '%LAPTOP%' and 
                                                    NOT TypeOfServiceProvided like '%PRINTER%' and 
                                                    NOT TypeOfServiceProvided like '%NETWORK%' and 
                                                    MONTH(DateAccomplished) = @2 and YEAR(DateAccomplished) = @3 ", SQLCon.sqlConnection);

            int a = (Convert.ToDateTime(month + " 01, 1900").Month);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@2", a);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@3", Int32.Parse(year));



            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);

            int i = 0;
            foreach (DataRow row in SQLCon.dataTable.Rows)
            {
                i++;
            }

            string number;
            number = i.ToString();

            return number;


        }

        private void CrystalReport2()
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "tcp:192.168.1.100,49172";
            string strDatabase = "SrisDb";
            string strUserId = "miso_server";
            string strPwd = "miso4321";

            var month = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
            var year = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);


            crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequestInfoes.DateAccomplished})) Like '*" + month + "*'" + " AND " +
                                                    "Year({ServiceRequestInfoes.DateAccomplished})= " + year +
                                                    " AND {ServiceRequestInfoes.Status} = True";

            rpt_Monthly report1 = new rpt_Monthly();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, strUserId, strPwd);
            report1.SetParameterValue("MonthLabel", month);
            // report1.SetParameterValue("param_year", year);

            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;
        }
    }
}
