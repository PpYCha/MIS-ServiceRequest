using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using ServiceRequestInformationSystem.UserForm;
using ServiceRequestInformationSystem.Models;

namespace ServiceRequestInformationSystem
{
    public partial class ucSystemDevAdmin : UserControl
    {
        public ucSystemDevAdmin()
        {
            InitializeComponent();

            label_Name.Text = WelcomeForm.FirstName + " " + WelcomeForm.LastName;
            radioButton_Weekly.Checked = true;
            LoadWeeklyRpt();

            LoadListSystemTitle();

            cb_PrintMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
            cb_PrintMonth.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames[DateTime.Now.AddMonths(-1).Month];

            cb_PrintYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cb_PrintYear.SelectedItem = DateTime.Now.Year;

        }

        private static int tempUserID;
        public static int titleId;
        public static string printMonth;
        public static string printYear;
        private static ucSystemDevAdmin _instance;

        public static ucSystemDevAdmin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSystemDevAdmin();

                return _instance;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

        }


        private void LoadWeeklyRpt()
        {
            dataGridView_ListWeek.Refresh();
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
                    WeeklyMonthly = 1 AND
                    SystemTitle = @SystemTitle
                    
                  ", SQLCon.sqlConnection);
                    SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@SystemTitle", cb_SystemTitle.Text);
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
                    WeeklyMonthly = 0
                ORDER BY
                    DateAccomplishment ASC
                  ", SQLCon.sqlConnection);
                    SQLCon.dataTable = new DataTable();
                    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                    dataGridView_ListWeek.DataSource = SQLCon.dataTable;

                    DesignTable();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "");
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
                    DATALENGTH(SystemTitle) > 0
                ORDER BY
                    SystemTitle
                ", SQLCon.sqlConnection);
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
                    DATALENGTH(SystemTitle) > 0
                ORDER BY
                    SystemTitle
                ", SQLCon.sqlConnection);
                    SQLCon.dataTable = new DataTable();
                    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                    cb_SystemTitle.DataSource = SQLCon.dataTable;

                    cb_SystemTitle.ValueMember = "TT_ID";
                    cb_SystemTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb_SystemTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cb_SystemTitle.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {


            }
        }

        private void dataGridView_ListWeek_MouseLeave(object sender, EventArgs e)
        {
            dataGridView_ListWeek.ClearSelection();
        }

        private void dataGridView_ListWeek_DoubleClick(object sender, EventArgs e)
        {

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
            }

        }

        private void ClearText()
        {
            tempUserID = 0;
            cb_SystemTitle.SelectedIndex = -1;
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

        private int id;
        private void bt_Print_Click(object sender, EventArgs e)
        {


            DeveloperReportForm developerReportForm = new DeveloperReportForm();
            string test = cb_SystemTitle.SelectedValue.ToString();
            titleId = Int32.Parse(test);
            printMonth = cb_PrintMonth.Text;
            printYear = cb_PrintYear.Text;
            developerReportForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string test = cb_SystemTitle.SelectedValue.ToString();
            MessageBox.Show(test + "");
        }

        private void ucSystemDevAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cb_SystemTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWeeklyRpt();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadWeeklyRpt();
        }
    }
}
