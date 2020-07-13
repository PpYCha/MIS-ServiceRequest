﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {           
            InitializeComponent();
          
            customizeDesign();

            LoadAllUserControll();

            Opacity = 0;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            DialogResult = DialogResult.OK;
           
            //backgroundWorker1.RunWorkerAsync();aa
            Opacity = 100;
        }

        private void LoadAllUserControll()
        {
            
              LoaducArchive();
            LoaducReports();
            LoaducAddRequest();
            panel_Body.Visible = false;
          
        }

        private void customizeDesign()
        {
            panel_SubMenu_Archived.Visible = false;
            panel_SubeMenu_Reports.Visible = false;
            panel_SubMenu_Request.Visible = false;
            panel_SubMenu_Accounts.Visible = false;
            panel_SubMenu_Import.Visible = false;
           
        }

        private void hideSubMenu()
        {
            if (panel_SubMenu_Archived.Visible == true)
                panel_SubMenu_Archived.Visible = false;

            if (panel_SubeMenu_Reports.Visible == true)
                panel_SubeMenu_Reports.Visible = false;

            if (panel_SubMenu_Request.Visible == true)
                panel_SubMenu_Request.Visible = false;

            if (panel_SubMenu_Accounts.Visible = true)           
                panel_SubMenu_Accounts.Visible = false;

            if (panel_SubMenu_Import.Visible == true)
            {
                panel_SubMenu_Import.Visible = false;
            }
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;

        }


        private void bt_AddRequest_Click_1(object sender, EventArgs e)
        {

            showSubMenu(panel_SubMenu_Request);
        }

        public void test(Panel panel)
        {
            LoaducAddRequest();
        }

        private void LoaducAddRequest()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucRequest.Intance))
            {
                panel_Body.Controls.Add(ucRequest.Intance);
                ucRequest.Intance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucRequest.Intance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Archived_Click(object sender, EventArgs e)
        {

            showSubMenu(panel_SubMenu_Archived);

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

            showSubMenu(panel_SubeMenu_Reports);
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
            hideSubMenu();
        }

        private void bt_rpt_Monthly_Click(object sender, EventArgs e)
        {
            LoaducReports();
            hideSubMenu();
        }

        private void bt_AddRequest_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            LoaducAddRequest();
        }

        private void bt_Libraries_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DataForm dataForm = new DataForm();
            dataForm.ShowDialog();

        }

       

        private void Bt_Menu_Accounts_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubMenu_Accounts);

        }

        private void Bt_AddAccounts_Click(object sender, EventArgs e)
        {
            LoaducAccounts();
        }

        private void LoaducAccounts()
        {
            hideSubMenu();
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
         
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
              
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
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
            showSubMenu(panel_SubMenu_Import);
        }
    }
}
