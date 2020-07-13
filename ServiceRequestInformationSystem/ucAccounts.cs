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

namespace ServiceRequestInformationSystem
{
    public partial class ucAccounts : UserControl
    {
        public ucAccounts()
        {
            InitializeComponent();
        }

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
            if (tb_Username.Text == "")
            {
                MessageBox.Show("Plesae Fill up the requird fields");
            }
            else
            {

    
            if (tb_ConfirmPassword.Text == tb_ConfirmPassword.Text)
            { 
            SQLCon.DbCon();
            SQLCon.sqlCommand = new SqlCommand("INSERT INTO Accounts VALUES(@Username,@Password,@FirstName,@LastName,@AccessLevel,@IsActive)", SQLCon.sqlConnection);
            SQLCon.sqlCommand.CommandType = CommandType.Text;
            SQLCon.sqlCommand.Parameters.AddWithValue("@Username", tb_Username.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@Password", tb_Password.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@FirstName", tb_FirstName.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@LastName", tb_LastName.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@AccessLevel", cb_AccessLevel.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@IsActive", 1);
            SQLCon.sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("ADD Successfully");
                }
            else
            {
                MessageBox.Show("Password did not match");
                tb_Password.Clear();
                tb_ConfirmPassword.Clear();
            }
            }
           
            ClearText();
        }

        private void ClearText()
        {
            tb_Username.Clear();
            tb_Password.Clear();
            tb_ConfirmPassword.Clear();
            tb_FirstName.Clear();
            tb_LastName.Clear();
            cb_AccessLevel.SelectedIndex = -1;

        }

        private void Tb_Password_Enter(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar = true;
        }

        private void Tb_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            tb_ConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
