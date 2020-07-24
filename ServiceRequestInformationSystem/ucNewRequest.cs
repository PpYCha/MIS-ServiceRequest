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
using ServiceRequestInformationSystem.Models;
using System.ComponentModel.Design.Data;

namespace ServiceRequestInformationSystem
{
    public partial class ucNewRequest : UserControl
    {

        private string[] techId  ;
      

        public ucNewRequest()
        {
            InitializeComponent();
            LoadRequest();
        }



        public void ucRequest_Load(object sender, EventArgs e)
        {
          
            LoadRequest();
            PopulateComboBox_Infoes();
        }

        private void PopulateComboBox_Infoes()
        {
            PopulateComboBox("TypeOfServices", "TS_ID", "TypeOfServiceProvided", cb_Service);
            PopulateComboBox("OfficeDepartments", "OD_ID", "OfficeDepartmentName", cb_Office);

            PopulateComboBox("RemarkInfoes", "Remark_ID", "Remars", cb_Remarks);
        }

        public  void RefreshList() 
        {
            PopulateComboBox("TypeOfServices", "TS_ID", "TypeOfServiceProvided", cb_Service);
        }

        private static ucNewRequest _instance;

        public static ucNewRequest Intance
        {
            get
            {
                if (_instance == null)

                    _instance = new ucNewRequest();
                return _instance;
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
                    SQLCon.sqlCommand.Parameters.AddWithValue("@4", DateTime.Now);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@5", DBNull.Value); //Time Left Column


                    if (cb_Remarks.SelectedIndex == -1)
                    {
                        SQLCon.sqlCommand.Parameters.AddWithValue("@7", cb_Remarks.Text);
                    }
                    else
                    {
                    SQLCon.sqlCommand.Parameters.AddWithValue("@7", cb_Remarks.SelectedValue);
                    }

                    SQLCon.sqlCommand.Parameters.AddWithValue("@9", tb_ServiceProvided.Text);
                    if (cb_Status.Checked == true)
                    {
                        SQLCon.sqlCommand.Parameters.AddWithValue("@6", dtp_Accomplished.Value);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@8", 1);
                    }
                    else
                    {
                        SQLCon.sqlCommand.Parameters.AddWithValue("@6", DBNull.Value);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@8", 0);
                    }
           


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
               
                
                LoadRequest();

                MetroFramework.MetroMessageBox.Show(this, "New Request Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextbox();
                }
                catch (Exception e)
                {

                    MetroFramework.MetroMessageBox.Show(this, "" + e, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cb_Status.Checked = false;
            tb_ServiceProvided.Clear();
            tb_Ids.Clear();
        }

        public void LoadRequest()
        {
            cb_Status.Enabled = false;
            dtp_Accomplished.Enabled = false;
            bt_Update.Enabled = false;
            bt_Update.BackColor = Color.DimGray;
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter(
               @"SELECT   
                    T1.SR_ID, 
                    T2.TypeOfServiceProvided AS [Type Of Service Provided], 
                    T1.RequestedBy AS [Requested By],  
                    T3.OfficeDepartmentName AS [Office], 
                    T1.DateRequested AS [Date Requested],
                    T1.TimeLeft AS [Time Left],
                    T1.DateAccomplished AS [Date Accomplished],
                    Remars AS [Remarks], 
                    Status AS [Status:],
                    Techinicians AS [Technicians]
                FROM 
                    ServiceRequestInfoes AS T1, 
                    TypeOfServices AS T2, 
                    OfficeDepartments AS T3, 
                    
                    RemarkInfoes AS T5
                 
                WHERE 
                    T1.Status = 0     AND
                    T1.TS_ID=T2.TS_ID AND 
                    T1.OD_ID=T3.OD_ID AND 
                    T1.Remark_ID=T5.Remark_ID", SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            dataGridView_ListOfRequest.DataSource = SQLCon.dataTable;
            dataGridView_ListOfRequest.Sort(dataGridView_ListOfRequest.Columns["Date Requested"], ListSortDirection.Ascending);
            DesignTable();
          
            foreach (DataGridViewRow row in dataGridView_ListOfRequest.Rows)
            {

                //CONVERTION FROM DATE TO SECONDS
                DateTime dateRequested = Convert.ToDateTime(row.Cells[4].Value.ToString());
                DateTime dateETA = new DateTime();
                if (dateRequested.DayOfWeek == DayOfWeek.Thursday)
                {
                    dateETA = Convert.ToDateTime(dateRequested.AddDays(4));
                }
                else if (dateRequested.DayOfWeek == DayOfWeek.Friday)
                {
                    dateETA = Convert.ToDateTime(dateRequested.AddDays(5));
                }
                else
                {
                    dateETA = Convert.ToDateTime(dateRequested.AddDays(2));
                }

                //DateTime dateETA = Convert.ToDateTime(row.Cells[6].Value.ToString());

                TimeSpan remainingTime = dateETA - DateTime.Now;
                if (DateTime.Now < dateETA)
                {
                    int seconds = Convert.ToInt32(remainingTime.TotalSeconds);
                    var timeLeft = TimeSpan.FromSeconds(int.Parse(seconds.ToString()));
                    var dateTime = String.Format("{0} days, {1} hours, {2} minutes, {3} seconds", timeLeft.Days, timeLeft.Hours, timeLeft.Minutes, timeLeft.Seconds);
                    row.Cells["Time Left"].Value = dateTime;
                    row.Cells["Time Left"].Style.BackColor = Color.FromArgb(255, 82, 82);
                }
                else if (DateTime.Now > dateETA)
                {
                    var dateTime = String.Format("{0} days, {1} hours, {2} minutes, {3} seconds", 0, 0, 0, 0);
                    row.Cells["Time Left"].Value = dateTime;
                    row.Cells["Time Left"].Style.BackColor = Color.Yellow;
                }
            }

          
            dataGridView_ListOfRequest.ClearSelection();

        }

        private void DesignTable()
        {
            dataGridView_ListOfRequest.Columns["SR_ID"].Visible = false;
            dataGridView_ListOfRequest.Columns["Status:"].Visible = false;
            //dataGridView_ListOfRequest.Columns["Remarks"].Visible = false;
            //dataGridView_ListOfRequest.Columns["Technicians"].Visible = false;

            dataGridView_ListOfRequest.ForeColor = Color.Black;
            dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_ListOfRequest.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView_ListOfRequest.Columns["Type Of Service Provided"].Width = 123;
            this.dataGridView_ListOfRequest.Columns["Requested By"].Width = 123;
            this.dataGridView_ListOfRequest.Columns["Office"].Width = 75;
            this.dataGridView_ListOfRequest.Columns["Date Requested"].Width = 109;
            this.dataGridView_ListOfRequest.Columns["Time Left"].Width = 223;
            this.dataGridView_ListOfRequest.Columns["Date Accomplished"].Width = 109;
            this.dataGridView_ListOfRequest.Columns["Technicians"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_ListOfRequest.Columns["Remarks"].Width = 200;

            dataGridView_ListOfRequest.Columns["Type Of Service Provided"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Requested By"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Office"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Date Requested"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Time Left"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Date Accomplished"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Technicians"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Remarks"].SortMode = DataGridViewColumnSortMode.NotSortable;


            dataGridView_ListOfRequest.BorderStyle = BorderStyle.None;
            dataGridView_ListOfRequest.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_ListOfRequest.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_ListOfRequest.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_ListOfRequest.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_ListOfRequest.BackgroundColor = Color.White;

            dataGridView_ListOfRequest.EnableHeadersVisualStyles = false;
            dataGridView_ListOfRequest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        public void PopulateComboBox(string tableName ,string valueName, string displayName, ComboBox cb_Name)
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



        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
            LoadRequest();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            LoadRequest();
            PopulateComboBox_Infoes();
            ClearTextbox();

        }

        private void dataGridView_ListOfRequest_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                cb_Status.Enabled = true;
                dtp_Accomplished.Enabled = true;
                bt_Update.Enabled = true;
                bt_Update.BackColor = Color.White;
                cb_Service.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[1].Value.ToString();
                tb_RequestedBy.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[2].Value.ToString();
                cb_Office.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[3].Value.ToString();
                dtp_Requested.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[4].Value.ToString();
                dtp_Accomplished.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[6].Value.ToString();
                //cb_Technician.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[7].Value.ToString();
                cb_Remarks.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[7].Value.ToString();
                tb_ServiceProvided.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[9].Value.ToString();
                string check = dataGridView_ListOfRequest.SelectedRows[0].Cells[8].Value.ToString();
                if (check == "True")
                {
                    cb_Status.Checked = true;
                }
                else
                {
                    cb_Status.Checked = false;
                }
            }
            catch (Exception)
            {


            }

        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
                int tempID = int.Parse(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand(
                    @"UPDATE ServiceRequestInfoes SET 
                    
                      TS_ID = @1,
                      RequestedBy = @2,
                      OD_ID = @3,
                      DateRequested = @4,
                      TimeLeft = @5,
                      DateAccomplished = @6,
                      
                      Remark_ID = @7,
                      Status = @8,
                      Techinicians = @9
                  WHERE
                       SR_ID=@10"
                    , SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;

                SQLCon.sqlCommand.Parameters.AddWithValue("@0", tempID);
                SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_Service.SelectedValue);
                SQLCon.sqlCommand.Parameters.AddWithValue("@2", tb_RequestedBy.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@3", cb_Office.SelectedValue);
            SQLCon.sqlCommand.Parameters.AddWithValue("@4", dtp_Requested.Value);
                SQLCon.sqlCommand.Parameters.AddWithValue("@5", DBNull.Value); //Time Left Column
           
                SQLCon.sqlCommand.Parameters.AddWithValue("@6", dtp_Accomplished.Value.Date);

                SQLCon.sqlCommand.Parameters.AddWithValue("@7", cb_Remarks.SelectedValue);
                SQLCon.sqlCommand.Parameters.AddWithValue("@9", tb_ServiceProvided.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@10", tempID);

            if (cb_Status.Checked == true)
                {
                    SQLCon.sqlCommand.Parameters.AddWithValue("@8", 1);
                }
                else
                {
                    SQLCon.sqlCommand.Parameters.AddWithValue("@8", 0);
                }
                SQLCon.sqlCommand.ExecuteNonQuery();



            if (tb_Ids.Text != "")
            {

            int sr_tempID = int.Parse(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
            SQLCon.sqlCommand = new SqlCommand(
              @"DELETE TechnicianRequests WHERE SR_ID = '" + sr_tempID + "'"
              , SQLCon.sqlConnection);

            SQLCon.sqlCommand.CommandType = CommandType.Text;
            SQLCon.sqlCommand.ExecuteNonQuery();


            string strValue = tb_Ids.Text;
            string[] strArray = strValue.Split(',');


            foreach (object obj in strArray)
            {

                string tempSP_ID = new string(tb_Ids.Text.ToArray());


                SQLCon.sqlCommand = new SqlCommand("INSERT INTO TechnicianRequests VALUES(@1, @2);", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@1", obj);
                SQLCon.sqlCommand.Parameters.AddWithValue("@2", sr_tempID);
                SQLCon.sqlCommand.ExecuteNonQuery();



            }

            }
        
            MessageBox.Show("Update Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRequest();
                ClearTextbox();
        
        }

        private void lb_ManageData_Click(object sender, EventArgs e)
        {
            DataForm dataForm = new DataForm();
            dataForm.ShowDialog();

        }

        //Validating Region

        private void tb_RequestedBy_Validating(object sender, CancelEventArgs e)
        {
            if (tb_RequestedBy.Text == "")
            {
                e.Cancel = true;

                errorProvider.SetError(tb_RequestedBy, "Please enter Name! Before you add..");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_RequestedBy, null);
            }

        }

        private void cb_Service_Validating(object sender, CancelEventArgs e)
        {
            if (cb_Service.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_Service, "Please select a Service! Before you add..");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_Service, null);
            }
        }

        private void cb_Office_Validating(object sender, CancelEventArgs e)
        {
            if (cb_Office.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_Office, "Please select a Office! Before you add..");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_Office, null);
            }
        }

        private void cb_Technician_Validating(object sender, CancelEventArgs e)
        {
            //if (cb_Technician.SelectedIndex == -1)
            //{
            //    e.Cancel = true;
            //    errorProvider.SetError(cb_Technician, "Please select a Technician Before you add..");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider.SetError(cb_Technician, null);
            //}
        }

        private void cb_Remarks_Validating(object sender, CancelEventArgs e)
        {

        }
        //End of Validating Region

        public static  string PopulateCheckTechId { get; set; }

        private void bt_MultipleTechinician_Click(object sender, EventArgs e)
        {
            PopulateCheckTechId = tb_ServiceProvided.Text;
            

            TechnicianForm technicianForm = new TechnicianForm();
            TechnicianForm.Choice = "ucNewRequest";
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



        private void bt_Refresh_Click_1(object sender, EventArgs e)
        {
         
        }

        private void lb_ManageData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView_ListOfRequest_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
