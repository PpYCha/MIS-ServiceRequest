using ServiceRequestInformationSystem.Models;
using System;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void bt_SaveUser_Click(object sender, EventArgs e)
        {
            RegisterAccount();
        }

        private void RegisterAccount()
        {
            if (!(String.IsNullOrEmpty(tb_Username.Text) || String.IsNullOrEmpty(tb_Password.Text) || String.IsNullOrEmpty(tb_FirstName.Text) || String.IsNullOrEmpty(tb_LastName.Text)))
            {
                if (tb_Password.Text == tb_ConfirmPassword.Text)
                {
                    using (SrisContext ctx = new SrisContext())
                    {
                        var registerUser = new Account
                        {
                            Username = tb_Username.Text,
                            Password = tb_Password.Text,
                            FirstName = tb_FirstName.Text,
                            MiddleName = tb_MiddleName.Text,
                            LastName = tb_LastName.Text,
                            AccessLevel = cb_UserRole.Text,
                            IsActive = false
                        };
                        ctx.Account.Add(registerUser);
                        ctx.SaveChanges();
                    }

                    MessageBox.Show("Registration Successfull.Please wait for Confirmation");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password did not match");
                }

            }
            else
            {
                MessageBox.Show("Please filled up the fields");

            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cb_UserRole.DataSource = Enum.GetValues(typeof(custom_Class.List));
        }
    }
}
