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

namespace ServiceRequestInformationSystem
{
    public partial class UpdateArchivedRequest : Form
    {
        public UpdateArchivedRequest()
        {
            InitializeComponent();
        }
        public static DataGridViewRow dgvr_UpdateArchiveRequest;
        private static int tempIdRequest;
        private string[] techId;

        public static string  PopulateCheckTechId { get;  set; }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            int tempID = tempIdRequest;
            SQLCon.DbCon();
            SQLCon.sqlCommand = new SqlCommand(
                @"UPDATE ServiceRequestInfoes SET 
                    
                      TypeOfServiceProvided = @1,
                      RequestedBy = @2,
                      OfficeDepartmentName = @3,
                      DateRequested = @4,
                      TimeLeft = @5,
                      DateAccomplished = @6,
                      
                      RemarkDeatails = @7,
                      Status = @8,
                      Techinicians = @9,
                      DateEntered = @11
                  WHERE
                       SR_ID=@10"
                , SQLCon.sqlConnection);
            SQLCon.sqlCommand.CommandType = CommandType.Text;

            SQLCon.sqlCommand.Parameters.AddWithValue("@0", tempID);
            SQLCon.sqlCommand.Parameters.AddWithValue("@1", comboBox1.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@2", tb_RequestedBy.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@3", cb_Office.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@4", dtp_Requested.Value);
            SQLCon.sqlCommand.Parameters.AddWithValue("@5", DBNull.Value); //Time Left Column

            SQLCon.sqlCommand.Parameters.AddWithValue("@6", dtp_Accomplished.Value.Date);

            SQLCon.sqlCommand.Parameters.AddWithValue("@7", cb_Remarks.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@9", tb_ServiceProvided.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@10", tempID);
                SQLCon.sqlCommand.Parameters.AddWithValue("@8", 1);
                SQLCon.sqlCommand.Parameters.AddWithValue("@11", DateTime.Now);
         
            SQLCon.sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Update Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void UpdateArchivedRequest_Load(object sender, EventArgs e)
        {
            tempIdRequest = Convert.ToInt32(dgvr_UpdateArchiveRequest.Cells[0].Value.ToString());
            comboBox1.Text = dgvr_UpdateArchiveRequest.Cells[1].Value.ToString();
            tb_RequestedBy.Text = dgvr_UpdateArchiveRequest.Cells[2].Value.ToString();
            cb_Office.Text = dgvr_UpdateArchiveRequest.Cells[3].Value.ToString();
            dtp_Requested.Value = Convert.ToDateTime(dgvr_UpdateArchiveRequest.Cells[4].Value.ToString());
            dtp_Accomplished.Value = Convert.ToDateTime(dgvr_UpdateArchiveRequest.Cells[5].Value.ToString());
            cb_Remarks.Text = dgvr_UpdateArchiveRequest.Cells[6].Value.ToString();
            tb_ServiceProvided.Text = dgvr_UpdateArchiveRequest.Cells[7].Value.ToString();
        }

        private void bt_MultipleTechinician_Click(object sender, EventArgs e)
        {
            PopulateCheckTechId = tb_ServiceProvided.Text;


            TechnicianForm technicianForm = new TechnicianForm();
            TechnicianForm.Choice = "updateCompletedRequest";
            technicianForm.ShowDialog();

            try
            {

                tb_ServiceProvided.Text = technicianForm.PopulateTechinician.ToString();



                tb_Ids.Text = technicianForm.SelectedProviderId.ToString();
                techId = technicianForm.SelectedProviderId.ToString().Split(',');

                foreach (var id in techId)
                {
                    string test = id;
                }

            }
            catch (Exception)
            {
                tb_ServiceProvided.Clear();

            }
        }
    }
}
