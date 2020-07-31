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
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;

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
        {
            get
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
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT DISTINCT " + displayName + " FROM " + tableName + " ORDER BY " + displayName, SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_Name.DataSource = SQLCon.dataTable;
            //   cb_Name.ValueMember = valueName;
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
                //try
                //{

                if (tb_ServiceProvided.Text.Contains(","))
                {
                    TechnicianForm technicianForm = new TechnicianForm();
                    SQLCon.DbCon();


                    SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO ServiceRequestInfoes (TypeOfServiceProvided, RequestedBy, OfficeDepartmentName, DateRequested, TimeLeft, DateAccomplished, Status, Techinicians, RemarkDeatails, DateEntered)  VALUES(
                        @TypeOfServiceProvided,
                        @RequestedBy,
                        @OfficeDepartmentName,
                        @DateRequested,
                        @TimeLeft,
                        @DateAccomplished,
                        @Status,
                        @Techinicians,
                        @RemarkDeatails,
                        @DateEntered);SELECT SCOPE_IDENTITY();", SQLCon.sqlConnection);

                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@TypeOfServiceProvided", cb_Service.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@RequestedBy", tb_RequestedBy.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@OfficeDepartmentName", cb_Office.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateRequested", dtp_Requested.Value);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@TimeLeft", DBNull.Value); //Time Left Column
                    SQLCon.sqlCommand.Parameters.AddWithValue("@RemarkDeatails", cb_Remarks.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Techinicians", tb_ServiceProvided.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplished", dtp_Accomplished.Value);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Status", true);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateEntered", DateTime.Now);
                    SQLCon.sqlCommand.ExecuteNonQuery();

                    //   SQLCon.sqlCommand = new SqlCommand

                }
                else
                {


                    TechnicianForm technicianForm = new TechnicianForm();
                    SQLCon.DbCon();


                    SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO ServiceRequestInfoes (TypeOfServiceProvided, RequestedBy, OfficeDepartmentName, DateRequested, TimeLeft, DateAccomplished, Status, Techinicians, RemarkDeatails, DateEntered)  VALUES(
                        @TypeOfServiceProvided,
                        @RequestedBy,
                        @OfficeDepartmentName,
                        @DateRequested,
                        @TimeLeft,
                        @DateAccomplished,
                        @Status,
                        @Techinicians,
                        @RemarkDeatails,
                        @DateEntered);SELECT SCOPE_IDENTITY();", SQLCon.sqlConnection);

                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@TypeOfServiceProvided", cb_Service.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@RequestedBy", tb_RequestedBy.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@OfficeDepartmentName", cb_Office.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateRequested", dtp_Requested.Value);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@TimeLeft", DBNull.Value); //Time Left Column
                    SQLCon.sqlCommand.Parameters.AddWithValue("@RemarkDeatails", cb_Remarks.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Techinicians", tb_ServiceProvided.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplished", dtp_Accomplished.Value);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Status", true);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateEntered", DateTime.Now);
                    SQLCon.sqlCommand.ExecuteNonQuery();

                    ClearTextbox();

                    PopulateComboBox_Infoes();
                    MetroFramework.MetroMessageBox.Show(this, "New Request Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //int insertedID = Convert.ToInt32(SQLCon.sqlCommand.ExecuteScalar());

                    //string strValue = tb_Ids.Text;
                    //string[] strArray = strValue.Split(',');

                    //foreach (object obj in strArray)
                    //{

                    //    string tempSP_ID = new string(tb_Ids.Text.ToArray());


                    //    SQLCon.sqlCommand = new SqlCommand("INSERT INTO TechnicianRequests VALUES(@1, @2);", SQLCon.sqlConnection);
                    //    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    //    SQLCon.sqlCommand.Parameters.AddWithValue("@1", obj);
                    //    SQLCon.sqlCommand.Parameters.AddWithValue("@2", insertedID);
                    //    SQLCon.sqlCommand.ExecuteNonQuery();



                    //}


                    ClearTextbox();

                    PopulateComboBox_Infoes();
                    MetroFramework.MetroMessageBox.Show(this, "New Request Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //}
                //catch (Exception e)
                //{

                //    MetroFramework.MetroMessageBox.Show(this, "" + e, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }


        }


        private void ClearTextbox()
        {
            errorProvider.Clear();
            cb_Service.SelectedIndex = -1;
            cb_Remarks.SelectedIndex = -1;
            cb_Office.SelectedIndex = -1;
            tb_RequestedBy.Clear();
            //cb_Technician.SelectedIndex = -1;


            tb_ServiceProvided.Clear();
            tb_Ids.Clear();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            PopulateComboBox_Infoes();
        }

        private void PopulateComboBox_Infoes()
        {
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "TypeOfServiceProvided", cb_Service);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "RemarkDeatails", cb_Remarks);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "OfficeDepartmentName", cb_Office);

        }

        private void cb_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_ToUpper.ToUpper(e);
        }

        private void cb_Office_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_ToUpper.ToUpper(e);
        }

        private void cb_Remarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_ToUpper.ToUpper(e);
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }


    }
}
