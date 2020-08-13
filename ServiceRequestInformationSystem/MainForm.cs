using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class MainForm : Form
    {

        public static string accessLevel;

        public MainForm()
        {
            InitializeComponent();

            CustomizeDesign();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            DialogResult = DialogResult.OK;


            if (accessLevel == "ADMIN")
            {
                bt_Menu_Accounts.Visible = true;
                bt_ImportExcel.Visible = true;
                bt_Menu_Import.Visible = true;
                bt_Menu_Reports.Visible = true;
                bt_Menu_BackUp.Visible = true;
                bt_Menu_SystemDevelopment.Visible = true;
                LoaducAddRequest();
            }
            else if (accessLevel == "TECHNICIAN")
            {
                bt_Menu_Accounts.Visible = false;
                bt_ImportExcel.Visible = false;
                bt_Menu_Import.Visible = false;
                bt_Menu_Reports.Visible = false;
                bt_Menu_BackUp.Visible = false;
                bt_Menu_SystemDevelopment.Visible = false;
                LoaducAddRequest();

            }
            else if (accessLevel == "PROGRAMMER")
            {
                bt_Menu_Accounts.Visible = false;
                bt_ImportExcel.Visible = false;
                bt_Menu_Import.Visible = false;
                bt_Menu_Reports.Visible = false;
                bt_Menu_BackUp.Visible = false;
                bt_Menu_SystemDevelopment.Visible = true;
                LoaducAddRequest();
            }
        }


        private void CustomizeDesign()
        {
            panel_SubMenu_Archived.Visible = false;
            panel_SubeMenu_Reports.Visible = false;
            panel_SubMenu_Request.Visible = false;
            panel_SubMenu_Accounts.Visible = false;
            panel_SubMenu_Import.Visible = false;
            panel_SubeMenu_SystemDevelopment.Visible = false;
        }

        private void HideSubMenu()
        {


            if (panel_SubMenu_Archived.Visible == true)
                panel_SubMenu_Archived.Visible = false;

            if (panel_SubeMenu_Reports.Visible == true)
                panel_SubeMenu_Reports.Visible = false;

            if (panel_SubMenu_Request.Visible == true)
                panel_SubMenu_Request.Visible = false;


            if (panel_SubMenu_Accounts.Visible == true)
                panel_SubMenu_Accounts.Visible = false;

            if (panel_SubMenu_Import.Visible == true)
                panel_SubMenu_Import.Visible = false;

            if (panel_SubeMenu_SystemDevelopment.Visible == true)
                panel_SubeMenu_SystemDevelopment.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;

        }


        private void bt_AddRequest_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
            LoaducAddRequest();
            ButtonInActive(bt_Menu_SystemDevelopment);
            ButtonInActive(bt_Menu_Accounts);
            ButtonActive(bt_Menu_AddRequest);
            ButtonInActive(bt_Menu_Archived);
            ButtonInActive(bt_Menu_BackUp);
            ButtonInActive(bt_Menu_Import);
            ButtonInActive(bt_Menu_Reports);
        }



        private void LoaducAddRequest()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucNewRequest.Intance))
            {
                panel_Body.Controls.Add(ucNewRequest.Intance);
                ucNewRequest.Intance.Dock = DockStyle.Fill;


            }
            else
            {

            }

            ucNewRequest.Intance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Archived_Click(object sender, EventArgs e)
        {
            //  ShowSubMenu(panel_SubMenu_Archived);

            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucArchived.Instance))
            {
                panel_Body.Controls.Add(ucArchived.Instance);
                ucArchived.Instance.Dock = DockStyle.Fill;
            }
            ucArchived.Instance.BringToFront();
            ucArchived archived = new ucArchived();
            archived.dataGridView_ListOfRequest.Refresh();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;

            ButtonInActive(bt_Menu_SystemDevelopment);
            ButtonInActive(bt_Menu_Accounts);
            ButtonInActive(bt_Menu_AddRequest);
            ButtonActive(bt_Menu_Archived);
            ButtonInActive(bt_Menu_BackUp);
            ButtonInActive(bt_Menu_Import);
            ButtonInActive(bt_Menu_Reports);
        }

        private void LoaducArchive()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucArchived.Instance))
            {
                panel_Body.Controls.Add(ucArchived.Instance);
                ucArchived.Instance.Dock = DockStyle.Fill;
            }
            ucArchived.Instance.BringToFront();
            ucArchived archived = new ucArchived();
            archived.dataGridView_ListOfRequest.Refresh();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_Reports_Click(object sender, EventArgs e)
        {

            ShowSubMenu(panel_SubeMenu_Reports);
            ButtonInActive(bt_Menu_SystemDevelopment);
            ButtonInActive(bt_Menu_Accounts);
            ButtonInActive(bt_Menu_AddRequest);
            ButtonInActive(bt_Menu_Archived);
            ButtonInActive(bt_Menu_BackUp);
            ButtonInActive(bt_Menu_Import);
            ButtonActive(bt_Menu_Reports);
        }

        private void LoaducReports()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucReports.Instance))
            {
                panel_Body.Controls.Add(ucReports.Instance);
                ucReports.Instance.Dock = DockStyle.Fill;
            }

            ucReports.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_RequestArchived_Click(object sender, EventArgs e)
        {
            LoaducArchive();
            HideSubMenu();
        }

        private void bt_rpt_Monthly_Click(object sender, EventArgs e)
        {
            LoaducReports();
            HideSubMenu();
        }

        private void bt_AddRequest_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            LoaducAddRequest();
        }

        //private void bt_Libraries_Click(object sender, EventArgs e)
        //{
        //    HideSubMenu();
        //    DataForm dataForm = new DataForm();
        //    dataForm.ShowDialog();

        //}



        private void Bt_Menu_Accounts_Click(object sender, EventArgs e)
        {
            //ShowSubMenu(panel_SubMenu_Accounts);
            ButtonInActive(bt_Menu_SystemDevelopment);
            ButtonActive(bt_Menu_Accounts);
            ButtonInActive(bt_Menu_AddRequest);
            ButtonInActive(bt_Menu_Archived);
            ButtonInActive(bt_Menu_BackUp);
            ButtonInActive(bt_Menu_Import);
            ButtonInActive(bt_Menu_Reports);
            LoaducAccounts();
        }

        private void Bt_AddAccounts_Click(object sender, EventArgs e)
        {
            LoaducAccounts();
        }

        private void LoaducAccounts()
        {
            //HideSubMenu();
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucAccounts.Instance))
            {
                panel_Body.Controls.Add(ucAccounts.Instance);
                ucAccounts.Instance.Dock = DockStyle.Fill;
            }

            ucAccounts.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Bt_MaxMin_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();



        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


        }

        private void Bt_Menu_Import_Click(object sender, EventArgs e)
        {
            ButtonInActive(bt_Menu_SystemDevelopment);
            ButtonInActive(bt_Menu_Accounts);
            ButtonInActive(bt_Menu_AddRequest);
            ButtonInActive(bt_Menu_Archived);
            ButtonInActive(bt_Menu_BackUp);
            ButtonActive(bt_Menu_Import);
            ButtonInActive(bt_Menu_Reports);
            ShowSubMenu(panel_SubMenu_Import);
        }

        private void bt_CompletedRequest_Click(object sender, EventArgs e)
        {
            LoaducCompletedRequest();
        }

        private void LoaducCompletedRequest()
        {
            HideSubMenu();
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucCompletedRequest.Instance))
            {
                panel_Body.Controls.Add(ucCompletedRequest.Instance);
                ucCompletedRequest.Instance.Dock = DockStyle.Fill;
            }

            ucCompletedRequest.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void bt_ImportExcel_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucImportExcel.Instance))
            {
                panel_Body.Controls.Add(ucImportExcel.Instance);
                ucImportExcel.Instance.Dock = DockStyle.Fill;
            }

            ucImportExcel.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

            //Opacity = 0;


            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();

            //DialogResult = DialogResult.OK;

            //CustomizeDesign();
            //Opacity = 100;



            //if (accessLevel == "ADMIN")
            //{
            //    bt_Menu_Accounts.Visible = true;
            //    bt_ImportExcel.Visible = true;
            //    bt_Menu_Import.Visible = true;
            //    bt_Menu_Reports.Visible = true;
            //    bt_Menu_BackUp.Visible = true;
            //    bt_Menu_SystemDevelopment.Visible = true;
            //    LoaducAddRequest();
            //}
            //else if (accessLevel == "TECHNICIAN")
            //{
            //    bt_Menu_Accounts.Visible = false;
            //    bt_ImportExcel.Visible = false;
            //    bt_Menu_Import.Visible = false;
            //    bt_Menu_Reports.Visible = false;
            //    bt_Menu_BackUp.Visible = false;
            //    bt_Menu_SystemDevelopment.Visible = false;
            //    LoaducAddRequest();

            //}
            //else if (accessLevel == "PROGRAMMER")
            //{
            //    bt_Menu_Accounts.Visible = false;
            //    bt_ImportExcel.Visible = false;
            //    bt_Menu_Import.Visible = false;
            //    bt_Menu_Reports.Visible = false;
            //    bt_Menu_BackUp.Visible = false;
            //    bt_Menu_SystemDevelopment.Visible = true;
            //    LoaducAddRequest();
            //}
        }

        private void bt_Menu_BackUp_Click(object sender, EventArgs e)
        {
            BackUpForm backUpForm = new BackUpForm();
            backUpForm.ShowDialog();
        }

        private void bt_Menu_SystemDevelopment_Click(object sender, EventArgs e)
        {
            //ShowSubMenu(panel_SubeMenu_SystemDevelopment);
            ButtonActive(bt_Menu_SystemDevelopment);
            ButtonInActive(bt_Menu_Accounts);
            ButtonInActive(bt_Menu_AddRequest);
            ButtonInActive(bt_Menu_Archived);
            ButtonInActive(bt_Menu_BackUp);
            ButtonInActive(bt_Menu_Import);
            ButtonInActive(bt_Menu_Reports);

            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucSystemDevWeekly.Instance))
            {
                panel_Body.Controls.Add(ucSystemDevWeekly.Instance);
                ucSystemDevWeekly.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                panel_Body.Controls.Add(ucSystemDevWeekly.Instance);
                ucSystemDevWeekly.Instance.Dock = DockStyle.Fill;
            }

            ucSystemDevWeekly.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void ButtonActive(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void ButtonInActive(Button button)
        {
            button.BackColor = Color.FromArgb(0, 90, 160);
            button.ForeColor = Color.White;
        }

        private void bt_WeeklyAccomlishment_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucSystemDevWeekly.Instance))
            {
                panel_Body.Controls.Add(ucSystemDevWeekly.Instance);
                ucSystemDevWeekly.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                panel_Body.Controls.Add(ucSystemDevWeekly.Instance);
                ucSystemDevWeekly.Instance.Dock = DockStyle.Fill;
            }

            ucSystemDevWeekly.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void bt_MonthlyAccomplishment_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucImportExcel.Instance))
            {
                panel_Body.Controls.Add(ucImportExcel.Instance);
                ucImportExcel.Instance.Dock = DockStyle.Fill;
            }

            ucImportExcel.Instance.BringToFront();
            Cursor.Current = Cursors.Default;
            panel_Body.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

