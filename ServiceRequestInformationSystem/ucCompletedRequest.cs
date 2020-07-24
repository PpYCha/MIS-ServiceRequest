using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ServiceRequestInformationSystem
{
    public partial class ucCompletedRequest : UserControl
    {
        public ucCompletedRequest()
        {
            InitializeComponent();
        }

        private string[] techId;

        private static ucCompletedRequest _instance;
        public static ucCompletedRequest Instance
        { get
            {
                if (_instance == null)
                    _instance = new ucCompletedRequest();
                return _instance;

            }
        }

        private void ucCompletedRequest_Load(object sender, EventArgs e)
        {
            PopulateComboBox_Infoes();

        }



        public void PopulateComboBox(string tableName, string valueName, string displayName, ComboBox cb_Name)
        {
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT * FROM " + tableName + " ORDER BY " + displayName, SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_Name.DataSource = SQLCon.dataTable;
            cb_Name.ValueMember = valueName;
            cb_Name.DisplayMember = displayName;
            cb_Name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_Name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Name.SelectedIndex = -1;
        }

        public static string PopulateCheckTechId { get; set; }

        private void bt_MultipleTechinician_Click(object sender, EventArgs e)
        {
            PopulateCheckTechId = tb_ServiceProvided.Text;


            TechnicianForm technicianForm = new TechnicianForm();
            TechnicianForm.Choice = "ucCompletedRequest";
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

        private void bt_Add_Click(object sender, EventArgs e)
        {
            SaveRequest();
        }

        private void SaveRequest()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //SQL

                try
                {

               

                    TechnicianForm technicianForm = new TechnicianForm();
                SQLCon.DbCon();


                SQLCon.sqlCommand = new SqlCommand("INSERT INTO ServiceRequestInfoes VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9);SELECT SCOPE_IDENTITY();", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_Service.SelectedValue);
                SQLCon.sqlCommand.Parameters.AddWithValue("@2", tb_RequestedBy.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@3", cb_Office.SelectedValue);
                SQLCon.sqlCommand.Parameters.AddWithValue("@4", dtp_Requested.Value.Date);
                SQLCon.sqlCommand.Parameters.AddWithValue("@5", DBNull.Value); //Time Left Column


                if (cb_Remarks.SelectedIndex == -1)
                {
                    SQLCon.sqlCommand.Parameters.AddWithValue("@7", 19);
                }
                else
                {
                    SQLCon.sqlCommand.Parameters.AddWithValue("@7", cb_Remarks.SelectedValue);
                }

                SQLCon.sqlCommand.Parameters.AddWithValue("@9", tb_ServiceProvided.Text);
              
                    SQLCon.sqlCommand.Parameters.AddWithValue("@6", dtp_Accomplished.Value.Date);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@8", 1);
             



                int insertedID = Convert.ToInt32(SQLCon.sqlCommand.ExecuteScalar());

                string strValue = tb_Ids.Text;
                string[] strArray = strValue.Split(',');

                foreach (object obj in strArray)
                {

                    string tempSP_ID = new string(tb_Ids.Text.ToArray());


                    SQLCon.sqlCommand = new SqlCommand("INSERT INTO TechnicianRequests VALUES(@1, @2);", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", obj);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@2", insertedID);
                    SQLCon.sqlCommand.ExecuteNonQuery();



                }




                MetroFramework.MetroMessageBox.Show(this, "New Request Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextbox();
                }
                catch (Exception)
                {

                  
                }
            }
        }


            private void ClearTextbox()
            {
                errorProvider.Clear();
                cb_Service.SelectedIndex = -1;
                tb_RequestedBy.Clear();
                cb_Office.SelectedIndex = -1;
                //cb_Technician.SelectedIndex = -1;
                cb_Remarks.SelectedIndex = -1;
               
                tb_ServiceProvided.Clear();
                tb_Ids.Clear();
            }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            PopulateComboBox_Infoes();
        }

        private void PopulateComboBox_Infoes()
        {
            PopulateComboBox("TypeOfServices", "TS_ID", "TypeOfServiceProvided", cb_Service);
            PopulateComboBox("OfficeDepartments", "OD_ID", "OfficeDepartmentName", cb_Office);

            PopulateComboBox("RemarkInfoes", "Remark_ID", "Remars", cb_Remarks);
        }
    }
    }
