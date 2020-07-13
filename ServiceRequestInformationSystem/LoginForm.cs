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

namespace ServiceRequestInformationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string accountValidation;

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
            
            SQLCon.DbCon();
            SQLCon.sql = "SELECT USER_ID, Username, Password, AccessLevel, IsActive FROM Accounts WHERE Username=@1 AND Password=@2";
            SQLCon.sqlCommand = new SqlCommand(SQLCon.sql, SQLCon.sqlConnection);
            SQLCon.sqlCommand.Parameters.AddWithValue("@1", tb_Username.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@2", tb_Password.Text);
            SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();

            while (SQLCon.sqlDataReader.Read())
            {
                WelcomeForm.Username = (SQLCon.sqlDataReader["Username"].ToString());
                WelcomeForm.Password = (SQLCon.sqlDataReader["Password"].ToString());
                accountValidation = (SQLCon.sqlDataReader["IsActive"].ToString());
            }


                if (WelcomeForm.Username == tb_Username.Text && WelcomeForm.Password == tb_Password.Text && accountValidation == "True")
                {
                    this.Close();
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.ShowDialog();
            }
                else if (accountValidation == "False" && WelcomeForm.Username == tb_Username.Text && WelcomeForm.Password == tb_Password.Text)
                {
                    MessageBox.Show("Your account has been suspended. Please contact the Administrator");
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
               
                
                 }

           
          
        }

        private void Pb_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
