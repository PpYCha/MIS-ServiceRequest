using ServiceRequestInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class TechnicianForm : MetroFramework.Forms.MetroForm
    {

        private string[] techId;

        public DataGridViewRow dgvr;
        public static string Choice;

        public TechnicianForm()
        {
            InitializeComponent();

        }

        private void TechnicianForm_Load(object sender, EventArgs e)
        {
            LoadTechinicianList();
        }




        private void LoadTechinicianList()
        {
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter(
               @"SELECT DISTINCT
                USER_ID,
                CONCAT(FirstName, ' ', LastName) AS Technician
                FROM
                   Accounts
                WHERE
                    AccessLevel = 'TECHNICIAN' AND
                    IsActive = 1
               ", SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            metroGrid1.DataSource = SQLCon.dataTable;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "Assign";
            checkColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;

            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            metroGrid1.Columns.Add(checkColumn);
            if (Choice == "ucNewRequest")
            {
                techId = ucNewRequest.PopulateCheckTechId.ToString().Split(',');
            }
            else if (Choice == "ucCompletedRequest")
            {
                techId = ucCompletedRequest.PopulateCheckTechId.ToString().Split(',');
            }
            else if (Choice == "updateCompletedRequest")
            {
                techId = UpdateArchivedRequest.PopulateCheckTechId.ToString().Split(',');
            }




            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                foreach (var id in techId)
                {
                    string test = row.Index.ToString();
                    int test2 = Convert.ToInt32(test);
                    if (id == metroGrid1.Rows[test2].Cells[1].Value.ToString())
                    {

                        row.Cells[2].Value = true;
                    }


                }
            }

            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[1].HeaderText = "Technicians";
            metroGrid1.Columns[1].ReadOnly = true;


            metroGrid1.Columns[1].Width = 300;

        }

        private void metroGridDesign()
        {

        }

        private void bt_AssignTechnician_Click(object sender, EventArgs e)
        {

            try
            {


                string message = string.Empty;
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["X"].Value);

                    if (isSelected)
                    {
                        SelectedProviderId += row.Cells["USER_ID"].Value.ToString() + ",";
                        message += SelectedProviderId.ToString();
                        PopulateTechinician += row.Cells["Technician"].Value.ToString() + ",";
                    }
                }

                PopulateTechinician = PopulateTechinician.Remove(PopulateTechinician.Length - 1);
                SelectedProviderId = SelectedProviderId.Remove(SelectedProviderId.Length - 1);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {

                DialogResult = DialogResult.OK;
            }
        }


        public string SelectedProviderId { get; set; }
        public string PopulateTechinician { get; set; }

        private void TechnicianForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

