﻿using System;
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

        private string[] techId;
        private int tempID;
        private DateTime dateTimeRequested;

        public ucNewRequest()
        {
            InitializeComponent();
            LoadRequest();
        }


        public void ucRequest_Load(object sender, EventArgs e)
        {
            dtp_Requested_Time.Format = DateTimePickerFormat.Custom;
            dtp_Requested_Time.CustomFormat = "hh:mm:tt";
            dtp_Requested_Time.ShowUpDown = true;
            radioButton_No.Checked = true;
            LoadRequest();
            PopulateComboBox_Infoes();
            cb_Remarks.Text = "Pending->";
        }

        private void PopulateComboBox_Infoes()
        {
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "TypeOfServiceProvided", cb_Service);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "RemarkDeatails", cb_Remarks);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "OfficeDepartmentName", cb_Office);

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

        public void RefreshList()
        {
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "TypeOfServiceProvided", cb_Service);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "RemarkDeatails", cb_Remarks);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "OfficeDepartmentName", cb_Office);
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
            if (!(string.IsNullOrWhiteSpace(tb_ToBeServiceProvided.Text) || string.IsNullOrWhiteSpace(tb_RequestedBy.Text) || string.IsNullOrWhiteSpace(cb_Office.Text) || string.IsNullOrWhiteSpace(cb_Remarks.Text)))
            {
                if (radioButton_Yes.Checked == true)
                {
                    if (!(string.IsNullOrEmpty(tb_ServiceProvided.Text)))
                    {

                        if (tempID == 0)
                        {
                            SaveRequest();
                        }
                        if (tempID != 0)
                        {
                            UpdateRequest();
                        }
                    }
                }
                if (radioButton_No.Checked == true)
                {
                    if (tempID == 0)
                    {
                        SaveRequest();
                    }
                    if (tempID != 0)
                    {
                        UpdateRequest();
                    }
                }


            }
            else
            {
                MessageBox.Show("Please fill up the form completely..");
            }

        }

        private void SaveRequest()
        {

            dateTimeRequested = dtp_Requested_Date.Value.Date + dtp_Requested_Time.Value.TimeOfDay;

            TechnicianForm technicianForm = new TechnicianForm();
            SQLCon.DbCon();


            SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO ServiceRequestInfoes (TypeOfServiceProvided, RequestedBy, OfficeDepartmentName, DateRequested, TimeLeft, DateAccomplished, Status, Techinicians, RemarkDeatails, DateEntered, AssignedTechnician)  VALUES(
                        @TypeOfServiceProvided,
                        @RequestedBy,
                        @OfficeDepartmentName,
                        @DateRequested,
                        @TimeLeft,
                        @DateAccomplished,
                        @Status,
                        @Techinicians,
                        @RemarkDeatails,
                        @DateEntered,
                        @AssignedTechnician);SELECT SCOPE_IDENTITY();", SQLCon.sqlConnection);

            SQLCon.sqlCommand.CommandType = CommandType.Text;
            SQLCon.sqlCommand.Parameters.AddWithValue("@TypeOfServiceProvided", cb_Service.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@RequestedBy", tb_RequestedBy.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@OfficeDepartmentName", cb_Office.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@DateRequested", dateTimeRequested);
            SQLCon.sqlCommand.Parameters.AddWithValue("@TimeLeft", DBNull.Value); //Time Left Column
            SQLCon.sqlCommand.Parameters.AddWithValue("@RemarkDeatails", cb_Remarks.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@Techinicians", tb_ServiceProvided.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@AssignedTechnician", tb_ToBeServiceProvided.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplished", DBNull.Value);
            SQLCon.sqlCommand.Parameters.AddWithValue("@Status", false);
            SQLCon.sqlCommand.Parameters.AddWithValue("@DateEntered", DBNull.Value);
            SQLCon.sqlCommand.ExecuteNonQuery();

            ClearTextbox();
            LoadRequest();
            PopulateComboBox_Infoes();
            MetroFramework.MetroMessageBox.Show(this, "New Request Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UpdateRequest()
        {
            tempID = int.Parse(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
            dateTimeRequested = dtp_Requested_Date.Value.Date + dtp_Requested_Time.Value.TimeOfDay;
            SQLCon.DbCon();
            SQLCon.sqlCommand = new SqlCommand(
                @"UPDATE ServiceRequestInfoes SET
                      TypeOfServiceProvided = @TypeOfServiceProvided,
                      RequestedBy = @RequestedBy,
                      OfficeDepartmentName = @OfficeDepartmentName,
                      DateRequested = @DateRequested,
                      TimeLeft = @TimeLeft,
                      DateAccomplished = @DateAccomplished,
                      RemarkDeatails = @RemarkDeatails,
                      Status = @Status,
                      Techinicians = @Techinicians,
                      DateEntered = @DateEntered,
                      AssignedTechnician = @AssignedTechnician
                  WHERE
                       SR_ID=@SR_ID"
                , SQLCon.sqlConnection);
            SQLCon.sqlCommand.CommandType = CommandType.Text;

            SQLCon.sqlCommand.Parameters.AddWithValue("@SR_ID", tempID);
            SQLCon.sqlCommand.Parameters.AddWithValue("@TypeOfServiceProvided", cb_Service.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@RequestedBy", tb_RequestedBy.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@OfficeDepartmentName", cb_Office.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@DateRequested", dateTimeRequested);
            SQLCon.sqlCommand.Parameters.AddWithValue("@TimeLeft", DBNull.Value); //Time Left Column

            SQLCon.sqlCommand.Parameters.AddWithValue("@RemarkDeatails", cb_Remarks.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@AssignedTechnician", tb_ToBeServiceProvided.Text);
            if (radioButton_Yes.Checked == true)
            {
                SQLCon.sqlCommand.Parameters.AddWithValue("@Status", 1);
                SQLCon.sqlCommand.Parameters.AddWithValue("@DateEntered", dtp_Accomplished.Value.Date);
                SQLCon.sqlCommand.Parameters.AddWithValue("@Techinicians", tb_ServiceProvided.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplished", dtp_Accomplished.Value.Date);
            }
            else
            {
                SQLCon.sqlCommand.Parameters.AddWithValue("@Status", 0);
                SQLCon.sqlCommand.Parameters.AddWithValue("@DateEntered", DBNull.Value);
                SQLCon.sqlCommand.Parameters.AddWithValue("@Techinicians", DBNull.Value);
                SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplished", DBNull.Value);
            }
            SQLCon.sqlCommand.ExecuteNonQuery();



            //if (tb_Ids.Text != "")
            //{

            //int sr_tempID = int.Parse(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
            //SQLCon.sqlCommand = new SqlCommand(
            //  @"DELETE TechnicianRequests WHERE SR_ID = '" + sr_tempID + "'"
            //  , SQLCon.sqlConnection);

            //SQLCon.sqlCommand.CommandType = CommandType.Text;
            //SQLCon.sqlCommand.ExecuteNonQuery();


            //string strValue = tb_Ids.Text;
            //string[] strArray = strValue.Split(',');


            //foreach (object obj in strArray)
            //{

            //    string tempSP_ID = new string(tb_Ids.Text.ToArray());


            //    SQLCon.sqlCommand = new SqlCommand("INSERT INTO TechnicianRequests VALUES(@1, @2);", SQLCon.sqlConnection);
            //    SQLCon.sqlCommand.CommandType = CommandType.Text;
            //    SQLCon.sqlCommand.Parameters.AddWithValue("@1", obj);
            //    SQLCon.sqlCommand.Parameters.AddWithValue("@2", sr_tempID);
            //    SQLCon.sqlCommand.ExecuteNonQuery();



            //}

            //}

            MessageBox.Show("Update Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRequest();
            ClearTextbox();

        }



        public void LoadRequest()
        {

            dtp_Accomplished.Enabled = false;

            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter(
               @"SELECT
                    T1.SR_ID,
                    T1.TypeOfServiceProvided AS [Type Of Service Provided],
                    T1.RequestedBy AS [Requested By],
                    T1.OfficeDepartmentName AS [Office],
                    T1.DateRequested AS [Date Requested],
                    T1.TimeLeft AS [Time Left],

                    T1.AssignedTechnician AS [Assigned Technician],
                    T1.RemarkDeatails AS [Remarks]
                FROM
                    ServiceRequestInfoes AS T1

                WHERE
                    T1.Status = 0
                  ", SQLCon.sqlConnection);
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
            // this.dataGridView_ListOfRequest.Columns["Date Accomplished"].Width = 109;
            this.dataGridView_ListOfRequest.Columns["Assigned Technician"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_ListOfRequest.Columns["Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView_ListOfRequest.Columns["Type Of Service Provided"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Requested By"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Office"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Date Requested"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Time Left"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //  dataGridView_ListOfRequest.Columns["Date Accomplished"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_ListOfRequest.Columns["Assigned Technician"].SortMode = DataGridViewColumnSortMode.NotSortable;
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





        private void bt_Clear_Click(object sender, EventArgs e)
        {
            PopulateComboBox_Infoes();
            ClearTextbox();
            LoadRequest();

        }

        private void ClearTextbox()
        {
            errorProvider.Clear();
            cb_Service.SelectedIndex = -1;
            cb_Remarks.SelectedIndex = -1;
            cb_Office.SelectedIndex = -1;
            tb_RequestedBy.Clear();
            radioButton_No.Checked = true;
            cb_Remarks.Text = "Pending->";
            tempID = 0;
            bt_Add.Enabled = true;

            tb_ToBeServiceProvided.Clear();
            tb_Ids.Clear();
            dtp_Requested_Time.Value = DateTime.Now;
            dtp_Requested_Date.Value = DateTime.Now;
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            ClearTextbox();
            LoadRequest();
            PopulateComboBox_Infoes();

        }

        private void dataGridView_ListOfRequest_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tempID = int.Parse(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
                cb_Service.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[1].Value.ToString();
                tb_RequestedBy.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[2].Value.ToString();
                cb_Office.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[3].Value.ToString();
                dtp_Requested_Date.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[4].Value.ToString();
                dtp_Requested_Time.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[4].Value.ToString();
                tb_ToBeServiceProvided.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[6].Value.ToString();
                cb_Remarks.Text = dataGridView_ListOfRequest.SelectedRows[0].Cells[7].Value.ToString();

            }
            catch (Exception)
            {


            }

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
            if (cb_Service.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(cb_Service, "Please enter a Service! Before you add..");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_Service, null);
            }
        }

        private void cb_Office_Validating(object sender, CancelEventArgs e)
        {
            if (cb_Office.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(cb_Office, "Please enter a Office! Before you add..");
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

        public static string PopulateCheckTechId { get; set; }





        private void bt_Refresh_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_ManageData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView_ListOfRequest_Leave(object sender, EventArgs e)
        {

        }

        private void cb_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);


        }

        private void cb_Office_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Remarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Remarks_Validating_1(object sender, CancelEventArgs e)
        {
            if (cb_Remarks.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(cb_Remarks, "Please enter a Office! Before you add..");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_Remarks, null);
            }
        }

        private void radioButton_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Yes.Checked == true)
            {
                dtp_Accomplished.Enabled = true;
                tb_ServiceProvided.Enabled = true;
                bt_MultipleTechinician.Enabled = true;
                label_Accom.Enabled = true;
                label_ServiceProvidedBy.Enabled = true;

            }
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Accomplished.Enabled = false;
            tb_ServiceProvided.Enabled = false;
            bt_MultipleTechinician.Enabled = false;
            label_Accom.Enabled = false;
            label_ServiceProvidedBy.Enabled = false;
        }

        private void bt_MultipleTechinicianAssign_Click(object sender, EventArgs e)
        {
            TechnicianLists("assignTech");
        }

        private void TechnicianLists(string x)
        {
            PopulateCheckTechId = tb_ToBeServiceProvided.Text;


            TechnicianForm technicianForm = new TechnicianForm();
            TechnicianForm.Choice = "ucNewRequest";
            technicianForm.ShowDialog();

            try
            {
                if (x == "assignTech")
                {
                    tb_ToBeServiceProvided.Text = technicianForm.PopulateTechinician.ToString();
                }

                tb_Ids.Text = technicianForm.SelectedProviderId.ToString();
                techId = technicianForm.SelectedProviderId.ToString().Split(',');

                foreach (var id in techId)
                {
                    string test = id;
                }

            }
            catch (Exception)
            {
                tb_ToBeServiceProvided.Clear();

            }
        }


        private void bt_MultipleTechinician_Click(object sender, EventArgs e)
        {
            TechnicianList("providedBy");
        }

        private void TechnicianList(string x)
        {
            PopulateCheckTechId = tb_ToBeServiceProvided.Text;


            TechnicianForm technicianForm = new TechnicianForm();
            TechnicianForm.Choice = "ucNewRequest";
            technicianForm.ShowDialog();

            try
            {
                if (x == "providedBy")
                {
                    tb_ServiceProvided.Text = technicianForm.PopulateTechinician.ToString();
                }

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
