using ServiceRequestInformationSystem.UserForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class ucProgrammerWeeklyRpt : UserControl
    {
        public ucProgrammerWeeklyRpt()
        {
            InitializeComponent();

            label_Name.Text = WelcomeForm.FirstName + " " + WelcomeForm.LastName;

            cb_Month.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
            cb_Month.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames[DateTime.Now.AddMonths(-1).Month];

            cb_Year.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cb_Year.SelectedItem = DateTime.Now.Year;

            DateTime dateDay = DateTime.Now;

            int day = dateDay.Day;

            if (day <= 7)
            {
                cb_WeekNo.SelectedIndex = 0;
            }
            else if (day >= 7 && day <= 14)
            {
                cb_WeekNo.SelectedIndex = 1;
            }
            else if (day >= 15 && day <= 21)
            {
                cb_WeekNo.SelectedIndex = 2;
            }
            else
            {
                cb_WeekNo.SelectedIndex = 3;
            }

            //var dateTime = DateTime.Now.AddBusinessDays(4);

            toolTip1.SetToolTip(toolTip_WeekNo, " Week1 = 1-7 Days \n Week2 = 8-14 Days \n Week3 = 15-21 Days \n Week4 = 22-End of the Month");

            LoadWeeklyRpt();
            LoadListSystemTitle(cb_SystemTitle);


        }

        public static string printSystemTitle;
        private static string printWeekNo;
        public static string printMonth;
        public static string printYear;

        private void LoadListSystemTitle(ComboBox cb)
        {


            SQLCon.DbCon();

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
            cb.DataSource = SQLCon.dataTable;
            cb.DisplayMember = "SystemTitle";
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb.SelectedIndex = -1;

        }

        private static ucProgrammerWeeklyRpt _instance;
        public static ucProgrammerWeeklyRpt Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProgrammerWeeklyRpt();
                return _instance;
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(cb_SystemTitle.Text)))
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand("INSERT INTO SystemDevelopments VALUES(@USER_ID,@DateAccomplish,@Accomplishment,@Remarks,@WeeklyMonthly,@SystemTitle)", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@USER_ID", WelcomeForm.AccountID);
                SQLCon.sqlCommand.Parameters.AddWithValue("@Remarks", tb_Memo.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@Accomplishment", tb_Accomplishment.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@SystemTitle", cb_SystemTitle.Text);




                SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplish", dateTimePicker_Date.Value.Date);
                SQLCon.sqlCommand.Parameters.AddWithValue("@WeeklyMonthly", 1);

                SQLCon.sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Save Successfully");

                LoadWeeklyRpt();
            }
            else
            {
                MessageBox.Show("Don't leave blank System Title");
            }
        }

        private void LoadWeeklyRpt()
        {
            SQLCon.DbCon();

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

        private void bt_Print_Click(object sender, EventArgs e)
        {
            cb_PrintMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
            cb_PrintMonth.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames[DateTime.Now.AddMonths(-1).Month];

            cb_PrintYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cb_PrintYear.SelectedItem = DateTime.Now.Year;

            DateTime dateDay = DateTime.Now;

            int day = dateDay.Day;

            if (day <= 7)
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (day >= 7 && day <= 14)
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (day >= 15 && day <= 21)
            {
                comboBox1.SelectedIndex = 2;
            }
            else
            {
                comboBox1.SelectedIndex = 3;
            }

            LoadListSystemTitle(cb_PrintSystemTitle);
            panel_Print.Visible = true;
            panel_Print.BringToFront();
        }

        private void bt_PrintOk_Click(object sender, EventArgs e)
        {
            SystemDevWeeklyReportForm systemDevWeeklyReportForm = new SystemDevWeeklyReportForm();
            printSystemTitle = cb_PrintSystemTitle.Text;
            printMonth = cb_PrintMonth.Text;
            printYear = cb_PrintYear.Text;
            printWeekNo = comboBox1.Text;

            systemDevWeeklyReportForm.ShowDialog();

        }
    }
}