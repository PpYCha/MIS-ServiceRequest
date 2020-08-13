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
using System.Diagnostics;
using System.Globalization;

namespace ServiceRequestInformationSystem
{
    public partial class ucSystemDevWeekly : UserControl
    {
        public ucSystemDevWeekly()
        {
            InitializeComponent();

            label_Name.Text = WelcomeForm.FirstName + " " + WelcomeForm.LastName;
            radioButton_Weekly.Checked = true;
            LoadWeeklyRpt();


            cb_Month.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                                                   .MonthNames.Take(12).ToList();
            cb_Month.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames[DateTime.Now.AddMonths(-1).Month];

            //metroComboBox2.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            //metroComboBox2.SelectedItem = DateTime.Now.Year;

            LoadListSystemTitle();
        }

        private static int tempUserID;
        private static ucSystemDevWeekly _instance;

        public static ucSystemDevWeekly Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSystemDevWeekly();

                return _instance;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(cb_SystemTitle.Text)))
            {
                if (tempUserID == 0)
                {
                    SaveWeekly();
                }
                else
                {
                    UpdateWeekly();
                }
            }
            else
            {
                MessageBox.Show("Dont leave blank the System Title");
            }

        }

        private void SaveWeekly()
        {
            try
            {


                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand("INSERT INTO SystemDevelopments VALUES(@USER_ID,@DateAccomplish,@Accomplishment,@Remarks,@WeeklyMonthly,@SystemTitle)", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@USER_ID", WelcomeForm.AccountID);
                SQLCon.sqlCommand.Parameters.AddWithValue("@Remarks", tb_Memo.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@Accomplishment", tb_Accomplishment.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@SystemTitle", cb_SystemTitle.Text);

                if (radioButton_Weekly.Checked == true)
                {
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplish", dateTimePicker_Date.Value.Date);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@WeeklyMonthly", 1);
                }
                else
                {
                    string month = cb_Month.Text.ToString();
                    string year = DateTime.Now.Year.ToString();
                    string dateInput = month + " 1, " + year;
                    var parsedDate = DateTime.Parse(dateInput);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplish", Convert.ToDateTime(parsedDate));
                    SQLCon.sqlCommand.Parameters.AddWithValue("@WeeklyMonthly", 0);
                }

                SQLCon.sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Save Successfully");

                ClearText();
                LoadWeeklyRpt();
                LoadListSystemTitle();
                DesignTable();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateWeekly()
        {
            try
            {

                if (radioButton_Weekly.Checked == true)
                {
                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand(
                        @"UPDATE SystemDevelopments SET
                        DateAccomplishment = @DateAccomplish,
                        Remarks = @Remarks,
                        Accomplishment = @Accomplishment,
                        SystemTitle = @SystemTitle
                  WHERE
                        SD_ID = @SD_ID"
                            , SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@SD_ID", tempUserID);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplish", dateTimePicker_Date.Value);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Remarks", tb_Memo.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Accomplishment", tb_Accomplishment.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@SystemTitle", cb_SystemTitle.Text);
                    SQLCon.sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                }

                else if (radioButtonMonthly.Checked == true)
                {
                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand(
                        @"UPDATE SystemDevelopments SET
                        DateAccomplishment = @DateAccomplish,
                        Remarks = @Remarks,
                        Accomplishment = @Accomplishment,
                        SystemTitle = @SystemTitle
                  WHERE
                        SD_ID = @SD_ID"
                            , SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@SD_ID", tempUserID);

                    string month = cb_Month.Text.ToString();
                    string year = DateTime.Now.Year.ToString();
                    string dateInput = month + " 1, " + year;
                    var parsedDate = DateTime.Parse(dateInput);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplish", Convert.ToDateTime(parsedDate));

                    SQLCon.sqlCommand.Parameters.AddWithValue("@Remarks", tb_Memo.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@Accomplishment", tb_Accomplishment.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@SystemTitle", cb_SystemTitle.Text);
                    SQLCon.sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                }

                ClearText();
                LoadWeeklyRpt();
                LoadListSystemTitle();
                DesignTable();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadWeeklyRpt()
        {
            try
            {


                SQLCon.DbCon();
                if (radioButton_Weekly.Checked == true)
                {
                    SQLCon.sqlDataApater = new SqlDataAdapter(
                       @"SELECT
                    SD_ID,
                    SystemTitle AS [System Title],
                    Accomplishment AS [Accomplishments],
                    DateAccomplishment AS [Date Accomplished],
                    Remarks AS [Remarks]
                FROM
                    SystemDevelopments
                WHERE
                    USER_ID = @1 AND
                    WeeklyMonthly = 1

                  ", SQLCon.sqlConnection);
                    SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", Convert.ToInt32(WelcomeForm.AccountID));
                    SQLCon.dataTable = new DataTable();
                    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                    dataGridView_ListWeek.DataSource = SQLCon.dataTable;
                    DesignTable();
                }
                else if (radioButtonMonthly.Checked == true)
                {
                    SQLCon.sqlDataApater = new SqlDataAdapter(
                  @"SELECT
                    SD_ID,
                    SystemTitle AS [System Title],
                    Accomplishment AS [Accomplishments],
                    concat(YEAR(DateAccomplishment) ,' ', DATENAME(month, DateAccomplishment)) AS [Date Accomplished],
                    Remarks AS [Remarks]
                FROM
                    SystemDevelopments
                WHERE
                    USER_ID = @1 AND
                    WeeklyMonthly = 0
                ORDER BY
                    DateAccomplishment ASC
                  ", SQLCon.sqlConnection);
                    SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", Convert.ToInt32(WelcomeForm.AccountID));
                    SQLCon.dataTable = new DataTable();
                    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                    dataGridView_ListWeek.DataSource = SQLCon.dataTable;

                    DesignTable();
                }
            }
            catch (Exception)
            {


            }

        }

        private void LoadListSystemTitle()
        {
            try
            {


                SQLCon.DbCon();
                if (radioButton_Weekly.Checked == true)
                {
                    SQLCon.sqlDataApater = new SqlDataAdapter(@"
                SELECT DISTINCT
                    SystemTitle
                FROM
                    SystemDevelopments
                WHERE
                    DATALENGTH(SystemTitle) > 0 AND
                    USER_ID = @1
                ORDER BY
                    SystemTitle
                ", SQLCon.sqlConnection);
                    SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", Convert.ToInt32(WelcomeForm.AccountID));
                    SQLCon.dataTable = new DataTable();
                    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                    cb_SystemTitle.DataSource = SQLCon.dataTable;
                    cb_SystemTitle.DisplayMember = "SystemTitle";
                    cb_SystemTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb_SystemTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cb_SystemTitle.SelectedIndex = -1;
                }
                else if (radioButtonMonthly.Checked == true)
                {
                    SQLCon.sqlDataApater = new SqlDataAdapter(@"
                SELECT DISTINCT
                    SystemTitle
                FROM
                    SystemDevelopments
                WHERE
                    DATALENGTH(SystemTitle) > 0 AND
                    USER_ID = @1
                ORDER BY
                    SystemTitle
                ", SQLCon.sqlConnection);
                    SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", Convert.ToInt32(WelcomeForm.AccountID));
                    SQLCon.dataTable = new DataTable();
                    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                    cb_SystemTitle.DataSource = SQLCon.dataTable;
                    cb_SystemTitle.DisplayMember = "SystemTitle";
                    cb_SystemTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb_SystemTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cb_SystemTitle.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_ListWeek_MouseLeave(object sender, EventArgs e)
        {
            dataGridView_ListWeek.ClearSelection();
        }

        private void dataGridView_ListWeek_DoubleClick(object sender, EventArgs e)
        {
            tempUserID = Convert.ToInt32(dataGridView_ListWeek.SelectedRows[0].Cells[0].Value.ToString());
            cb_SystemTitle.Text = dataGridView_ListWeek.SelectedRows[0].Cells[1].Value.ToString();
            tb_Accomplishment.Text = dataGridView_ListWeek.SelectedRows[0].Cells[2].Value.ToString();
            if (radioButton_Weekly.Checked == true)
            {
                dateTimePicker_Date.Text = dataGridView_ListWeek.SelectedRows[0].Cells[3].Value.ToString();

            }
            else if (radioButtonMonthly.Checked == true)
            {
                string month = dataGridView_ListWeek.SelectedRows[0].Cells[3].Value.ToString();
                month = month.Remove(0, 5);
                cb_Month.Text = month;
            }

            tb_Memo.Text = dataGridView_ListWeek.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Weekly.Checked == true)
            {
                radioButtonMonthly.Checked = false;
                ClearText();
                LoadWeeklyRpt();
                LoadListSystemTitle();
                labelTitle.Text = "System Daily Development";
                dateTimePicker_Date.BringToFront();
            }
        }

        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMonthly.Checked == true)
            {
                radioButton_Weekly.Checked = false;
                ClearText();
                LoadWeeklyRpt();
                LoadListSystemTitle();
                labelTitle.Text = "System Monthly Development";
                cb_Month.BringToFront();
            }

        }

        private void ClearText()
        {
            tempUserID = 0;
            tb_Accomplishment.Clear();
            tb_Memo.Clear();
            cb_SystemTitle.SelectedIndex = -1;
            dateTimePicker_Date.Value = DateTime.Now;
        }

        private void cb_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void DesignTable()
        {
            dataGridView_ListWeek.Columns["SD_ID"].Visible = false;

            dataGridView_ListWeek.ForeColor = Color.Black;
            dataGridView_ListWeek.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_ListWeek.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //this.dataGridView_ListOfRequest.Columns["Type Of Service Provided"].Width = 123;

            //this.dataGridView_ListOfRequest.Columns["Assigned Technician"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.dataGridView_ListOfRequest.Columns["Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dataGridView_ListOfRequest.Columns["Type Of Service Provided"].SortMode = DataGridViewColumnSortMode.NotSortable;


            dataGridView_ListWeek.BorderStyle = BorderStyle.FixedSingle;
            dataGridView_ListWeek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_ListWeek.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_ListWeek.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_ListWeek.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_ListWeek.BackgroundColor = Color.White;

            dataGridView_ListWeek.EnableHeadersVisualStyles = false;
            dataGridView_ListWeek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_ListWeek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_ListWeek.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
