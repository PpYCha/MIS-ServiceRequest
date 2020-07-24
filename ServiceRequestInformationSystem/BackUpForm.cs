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
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

     

        private void bt_BackUp_Click(object sender, EventArgs e)
        {
            BackupDatabase();

        }

        private void BackupDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
