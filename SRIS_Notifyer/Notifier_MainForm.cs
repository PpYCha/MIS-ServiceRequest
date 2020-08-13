using Microsoft.Win32;
using SRIS_Notifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SRIS_Notifier
{
    public partial class Notifyer_MainForm : Form
    {

        public static string accessLevel { get; set; }

        public Notifyer_MainForm()
        {
            InitializeComponent();

           


            //LoginForm login = new LoginForm();
            //login.ShowDialog();

            //if (accessLevel == "ADMIN")
            //{
            //    groupBox_NotifierSettings.Show();
            //}
            //else
            //{
            //    groupBox_NotifierSettings.Hide();
            //}
        }

        private void Notifyer_MainForm_Load(object sender, EventArgs e)
        {
            //string notifierStatus = ConfigurationManager.AppSettings["notifierStatus"];
            //string timeInterval = ConfigurationManager.AppSettings["timeInterval"];





            var notifierStatus = ConfigurationManager.AppSettings["notifierStatus"].ToString();
            var timeInterval = ConfigurationManager.AppSettings["timeInterval"].ToString();

            checkBox_Status.Checked = bool.Parse(notifierStatus);
            numericUpDown_TimeInterval.Value = decimal.Parse(timeInterval);

            SetStartUp();
            StartNotifier();
        }

        public static void SetStartUp()
        {
            try
            {

                string keys =
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
                string value = "Automated";

                if (Registry.GetValue(keys, value, null) == null)
                {
                    // if key doesn't exist
                    using (RegistryKey key =
                    Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                    {
                        string path = Application.ExecutablePath;
                        key.SetValue("SRISN", path);
                        key.Dispose();
                        key.Flush();
                    }
                }
                else
                {
                    //if key Exist
                }
            }
            catch (Exception ex)
            {

            }

        }

        private string techName = String.Empty;
        private string checkNameIfExist = String.Empty;

        private void StartNotifier()
        {
            LoadRequest();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(5);




            var timer = new System.Threading.Timer((e) =>
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand(@"SELECT DISTINCT AssignedTechnician FROM ServiceRequestInfoes WHERE Status = 0", SQLCon.sqlConnection);
                SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();

                while (SQLCon.sqlDataReader.Read())
                {
                    techName += (SQLCon.sqlDataReader["AssignedTechnician"].ToString()) + ", \n";
                }

                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"image\icons8_maintenance.ico"));
                notifyIcon1.Text = "URGENT REPAIR";
                notifyIcon1.Visible = true;

                notifyIcon1.BalloonTipTitle = "HAVE URGENT REPAIR";
                notifyIcon1.BalloonTipText = "There is a pending request for: \n" + techName;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(100);

                techName = String.Empty;

            }, null, startTimeSpan, periodTimeSpan);


        }

        private void LoadRequest()
        {



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



        }



        private void notifyIcon()
        {

            foreach (DataGridViewRow item in dataGridView_ListOfRequest.Rows)
            {
                techName += item.Cells[6].Value.ToString() + ",";

            }

            notifyIcon1.Icon = new System.Drawing.Icon(@"D:\icons8_maintenance.ico");
            notifyIcon1.Text = "URGENT REPAIR";
            notifyIcon1.Visible = true;

            notifyIcon1.BalloonTipTitle = "HAVE URGENT REPAIR";
            notifyIcon1.BalloonTipText = techName;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;






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

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Notifyer_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            StartNotifier();
            e.Cancel = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void timer_Start_Tick(object sender, EventArgs e)
        {
            LoadRequest();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            LoadRequest();
        }

        private void bt_SaveNotifierSettings_Click(object sender, EventArgs e)
        {
            var notifierStatus = ConfigurationManager.AppSettings["notifierStatus"].ToString();
            var timeInterval = ConfigurationManager.AppSettings["timeInterval"].ToString();
            if (notifierStatus.Contains("on"))
            {
                checkBox_Status.Checked = true;
                numericUpDown_TimeInterval.Value = Convert.ToDecimal(timeInterval);
            }
            else
            {
                checkBox_Status.Checked = false;
                numericUpDown_TimeInterval.Value = Convert.ToDecimal(timeInterval);
            }
        }
    }
}
