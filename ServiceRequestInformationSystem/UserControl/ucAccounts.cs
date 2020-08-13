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
using System.Runtime.InteropServices;

namespace ServiceRequestInformationSystem
{
    public partial class ucAccounts : UserControl
    {
        public ucAccounts()
        {
            InitializeComponent();
        }

        private string tempId_UserList;
        private static ucAccounts _instance;

        public static ucAccounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAccounts();

                return _instance;
            }
        }

        private void Bt_SaveUser_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(tb_Username.Text))
            {
                MessageBox.Show("Plesae Fill up the required fields");
            }
            else
            {
                if (String.IsNullOrEmpty(tempId_UserList))
                {



                    if (tb_Password.Text == tb_ConfirmPassword.Text)
                    {
                        SQLCon.DbCon();
                        SQLCon.sqlCommand = new SqlCommand("INSERT INTO Accounts VALUES(@Username,@Password,@FirstName,@LastName,@AccessLevel,@IsActive,@IsLogon,@MiddleName)", SQLCon.sqlConnection);
                        SQLCon.sqlCommand.CommandType = CommandType.Text;
                        SQLCon.sqlCommand.Parameters.AddWithValue("@Username", tb_Username.Text);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@Password", tb_Password.Text);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@FirstName", tb_FirstName.Text);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@MiddleName", tb_MiddleName.Text);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@LastName", tb_LastName.Text);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@AccessLevel", cb_AccessLevel.Text);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@IsActive", 1);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@IsLogon", 1);
                        SQLCon.sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("User added Successfully");
                        LoadUserList();
                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                        tb_Password.Clear();
                        tb_ConfirmPassword.Clear();
                    }
                }
                else
                {
                    using (SrisContext ctx = new SrisContext())
                    {

                        int tempId = Convert.ToInt32(tempId_UserList);
                        Account userAccount = ctx.Account.Where(x => x.USER_ID == tempId).FirstOrDefault();
                        userAccount.Username = tb_Username.Text;
                        userAccount.Password = tb_Password.Text;
                        userAccount.FirstName = tb_FirstName.Text;
                        userAccount.MiddleName = tb_MiddleName.Text;
                        userAccount.LastName = tb_LastName.Text;
                        userAccount.AccessLevel = cb_AccessLevel.Text;
                        userAccount.IsActive = checkBox_Status.Checked;
                        ctx.SaveChanges();
                        MessageBox.Show("User update Successfully");
                        LoadUserList();
                        tempId_UserList = null;
                        dataGridView_UserList.ClearSelection();
                    }
                }

            }

            ClearText();


        }



        private void customDesignDataGrid()
        {
            dataGridView_UserList.Columns["USER_ID"].Visible = false;
            dataGridView_UserList.Columns["Password"].Visible = false;

        }

        private void ClearText()
        {
            tb_Username.Clear();
            tb_Password.Clear();
            tb_ConfirmPassword.Clear();
            tb_FirstName.Clear();
            tb_LastName.Clear();
            cb_AccessLevel.SelectedIndex = -1;
            tempId_UserList = null;
        }

        private void Tb_Password_Enter(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar = true;
        }

        private void Tb_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            tb_ConfirmPassword.UseSystemPasswordChar = true;
        }

        private void ucAccounts_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            using (SrisContext ctx = new SrisContext())
            {
                dataGridView_UserList.DataSource = ctx.Account.ToList();

                customDesignDataGrid();
            }

            dataGridView_UserList.Columns["IsLogOn"].Visible = false;
            dataGridView_UserList.Columns["TypeOfServices"].Visible = false;
            dataGridView_UserList.Columns["TechnicianRequest"].Visible = false;
            dataGridView_UserList.Columns["SystemDevelopment"].Visible = false;


            custom_Class custom_Class = new custom_Class();
            cb_AccessLevel.DataSource = Enum.GetValues(typeof(custom_Class.List));

        }

        private void dataGridView_UserList_DoubleClick(object sender, EventArgs e)
        {
            tempId_UserList = dataGridView_UserList.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                tb_Username.Text = dataGridView_UserList.SelectedRows[0].Cells[1].Value.ToString();
                tb_Password.Text = dataGridView_UserList.SelectedRows[0].Cells[2].Value.ToString();
                tb_FirstName.Text = dataGridView_UserList.SelectedRows[0].Cells[3].Value.ToString();
                tb_MiddleName.Text = dataGridView_UserList.SelectedRows[0].Cells[4].Value.ToString();
                tb_LastName.Text = dataGridView_UserList.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                tb_MiddleName.Text = " ";
            }

            cb_AccessLevel.SelectedItem = dataGridView_UserList.SelectedRows[0].Cells[6].Value.ToString();
            checkBox_Status.Checked = Convert.ToBoolean(dataGridView_UserList.SelectedRows[0].Cells[7].Value.ToString());
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadUserList();
        }
    }
}
