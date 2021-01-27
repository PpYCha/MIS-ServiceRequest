using ServiceRequestInformationSystem.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem.UserForm
{
    public partial class RptYearlyForm : Form
    {
        public RptYearlyForm()
        {
            InitializeComponent();
        }

        private void RptYearlyForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
        }

        private void bt_printView_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDb";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;


            var year = comboBox1.GetItemText(comboBox1.SelectedItem);
            string desktopRepairCount = "DESKTOP";
            string laptopRepairCount = "LAPTOP";
            string printerRepairCount = "PRINTER";
            string netWorkConnectivityRepairCount = "NETWORK";
            string othersRepair = string.Empty;


            //crystalReportViewer1.SelectionFormula = "Year({ServiceRequestInfoes.DateAccomplished})= " + year +
            //                                        " AND {ServiceRequestInfoes.Status} = True";

            string totalCount = TotalService(year);

            string drCount = GetCount(desktopRepairCount, year);
            string lrCount = GetCount(laptopRepairCount, year);
            string prCount = GetCount(printerRepairCount, year);
            string nrCOunt = GetCount(netWorkConnectivityRepairCount, year);
            string orCOunt = GetOthers(othersRepair, year);




            rpt_Yearly_Technicians report1 = new rpt_Yearly_Technicians();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
            report1.SetParameterValue("YearLabel", year);
            report1.SetParameterValue("DesktopRepair", drCount);
            report1.SetParameterValue("LaptopRepair", lrCount);
            report1.SetParameterValue("PrinterRepair", prCount);
            report1.SetParameterValue("NetWorkConnectivityRepairCount", nrCOunt);
            report1.SetParameterValue("OthersRepair", orCOunt);
            report1.SetParameterValue("Total", totalCount);
            // report1.SetParameterValue("param_year", year);

            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;
        }

        private string TotalService(string year)
        {
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT * from ServiceRequestInfoes where YEAR(DateAccomplished) = @3 ", SQLCon.sqlConnection);


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

        private string GetCount(string count, string year)
        {
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT * from ServiceRequestInfoes where TypeOfServiceProvided like @1 and YEAR(DateAccomplished) = @3 ", SQLCon.sqlConnection);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", "%" + count + "%");

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

        private string GetOthers(string count, string year)
        {
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT * from ServiceRequestInfoes where NOT TypeOfServiceProvided like '%DESKTOP%' and 
                                                    NOT TypeOfServiceProvided like '%LAPTOP%' and 
                                                    NOT TypeOfServiceProvided like '%PRINTER%' and 
                                                    NOT TypeOfServiceProvided like '%NETWORK%' and 
                                                    YEAR(DateAccomplished) = @3 ", SQLCon.sqlConnection);


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
    }
}
