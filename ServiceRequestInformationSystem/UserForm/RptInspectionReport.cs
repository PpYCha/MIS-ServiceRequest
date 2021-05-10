using ServiceRequestInformationSystem.Models;
using ServiceRequestInformationSystem.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem.UserForm
{
    public partial class RptInspectionReport : Form
    {
        public RptInspectionReport()
        {
            InitializeComponent();
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            CrystalReport();
        }

        private void CrystalReport()
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDb";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;


            

            rpt_Inspection report1 = new rpt_Inspection();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
            report1.SetParameterValue("IRID", Int32.Parse(tb_ID.Text));
            report1.SetParameterValue("FP_II", Int32.Parse(tb_ID.Text));
            report1.SetParameterValue("II_ID", Int32.Parse(tb_ID.Text));
            report1.SetParameterValue("R_II", Int32.Parse(tb_ID.Text));
            report1.SetParameterValue("US_II", Int32.Parse(tb_ID.Text));
            report1.SetParameterValue("PI_II", Int32.Parse(tb_ID.Text));
            
           
            
            if (cb_Procedure.Checked == false)
            {
            report1.PageHeaderSection2.SectionFormat.EnableSuppress = true;
            }
            if (cb_Particulars.Checked == false)
            {
                report1.PageHeaderSection4.SectionFormat.EnableSuppress = true;
            }
            if (cb_Recommendation.Checked == false)
            {
                report1.PageHeaderSection5.SectionFormat.EnableSuppress = true;
            }

            if (cb_UnitSpecification.Checked == false)
            {
                report1.PageHeaderSection1.SectionFormat.EnableSuppress = true;
            }
       
            // report1.SetParameterValue("param_year", year);

            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;
        }

        private void RptInspectionReport_Load(object sender, EventArgs e)
        {
            using (SrisContext ctx = new SrisContext())
            {
              
                var lastInspection = ctx.InspectionInfo.OrderByDescending(x => x.II_ID).FirstOrDefault();

                tb_ID.Text = lastInspection.II_ID.ToString();

               
                    if (ctx.ProcedureTest.Any(x => x.II_ID == lastInspection.II_ID))
                {
                    cb_Procedure.Checked = true;
                }
                if (ctx.FindingParticular.Any(x => x.II_ID == lastInspection.II_ID))
                {
                   cb_Particulars.Checked = true;
                }
                if (ctx.Recommendation.Any(x => x.II_ID == lastInspection.II_ID))
                {
                    cb_Recommendation.Checked = true;
                }
                if (ctx.UnitSpecification.Any(x => x.II_ID == lastInspection.II_ID))
                {
                    cb_UnitSpecification.Checked = true;
                }



                CrystalReport();
            }
        }
    }
}
