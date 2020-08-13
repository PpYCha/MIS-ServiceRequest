using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS_Notifier
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private string accountValidation;
        private string role;

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text == "USERNAME")
            {
                tb_Username.Text = "";
                tb_Username.ForeColor = Color.LightGray;
            }
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "USERNAME";
                tb_Username.ForeColor = Color.DimGray;
            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "PASSWORD")
            {
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.LightGray;
                tb_Password.UseSystemPasswordChar = true;
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "PASSWORD";
                tb_Password.ForeColor = Color.DimGray;
                tb_Password.UseSystemPasswordChar = false;
            }
        }

        private void bt_Enter_Click(object sender, EventArgs e)
        {
            LoginValidation();
        }

        private void LoginValidation()
        {
            Cursor.Current = Cursors.WaitCursor;
            SQLCon.DbCon();
            SQLCon.sql = "SELECT USER_ID, Username, Password, FirstName, LastName , AccessLevel, IsActive FROM Accounts WHERE Username=@1 AND Password=@2";
            SQLCon.sqlCommand = new SqlCommand(SQLCon.sql, SQLCon.sqlConnection);
            SQLCon.sqlCommand.Parameters.AddWithValue("@1", tb_Username.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@2", tb_Password.Text);
            SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();

            while (SQLCon.sqlDataReader.Read())
            {
                AccountValidationClass.AccountID = Convert.ToInt32((SQLCon.sqlDataReader["USER_ID"].ToString()));
                AccountValidationClass.Username = (SQLCon.sqlDataReader["Username"].ToString());
                AccountValidationClass.Password = (SQLCon.sqlDataReader["Password"].ToString());
                AccountValidationClass.FirstName = (SQLCon.sqlDataReader["FirstName"].ToString());
                AccountValidationClass.LastName = (SQLCon.sqlDataReader["LastName"].ToString());
                accountValidation = (SQLCon.sqlDataReader["IsActive"].ToString());
                role = (SQLCon.sqlDataReader["AccessLevel"].ToString());
            }


            if (AccountValidationClass.Username == tb_Username.Text && AccountValidationClass.Password == tb_Password.Text && accountValidation == "True")
            {


                if (role == "ADMIN")
                {
                    Notifyer_MainForm.accessLevel = "ADMIN";

                }
                else if (role == "TECHNICIAN")
                {
                    Notifyer_MainForm.accessLevel = "TECHNICIAN";
                }
                else if (role == "PROGRAMMER")
                {
                    Notifyer_MainForm.accessLevel = "PROGRAMMER";
                }

                this.Close();

            }
            else if (accountValidation == "False" && AccountValidationClass.Username == tb_Username.Text && AccountValidationClass.Password == tb_Password.Text)
            {
                MessageBox.Show("Your account has been suspended. Please contact the Administrator");
                tb_Password.Clear();
                tb_Username.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
                tb_Password.Clear();
                tb_Username.Clear();

                //}
                Cursor.Current = Cursors.Default;
            }





        }

        private void lb_LoginAsGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
