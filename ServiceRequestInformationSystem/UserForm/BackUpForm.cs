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

        SqlConnection con;
        SqlCommand cmd;

        private string serverName = "DESKTOP-AMNVG75";
        private string dataBasefileNameBackUp = "SrisDb" + ".bak";
        private string dataBaseFileName = "SrisDb";

        private void bt_BackUp_Click(object sender, EventArgs e)
        {
            try
            {


                con = new SqlConnection("Data Source=" + serverName + "; Database=Master;data source=.; Integrated Security=true");
                con.Open();
                cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);
                con.Close();
                SaveFileDialog1.FileName = dataBasefileNameBackUp + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm");

                SaveFileDialog1.DefaultExt = "bak";
                SaveFileDialog1.Filter = "BAK files (*.bak)|*.bak";
                SaveFileDialog1.RestoreDirectory = true;
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = null;
                    s = SaveFileDialog1.FileName;
                    string query = ("Backup database " + dataBaseFileName + " to disk='" + s + "'");
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Backup Succesfull", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("", "Please backup to external drive or other partition", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_Restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Back up (*.bak)|*.bak";
            opd.RestoreDirectory = true;



            if (opd.ShowDialog() == DialogResult.OK)
            {
                SQLCon.DbCon();


                SQLCon.sqlCommand = new SqlCommand(@"USE MASTER RESTORE DATABASE SrisDb FROM DISK = '" + opd.FileName + "' WITH REPLACE", SQLCon.sqlConnection);
                SQLCon.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Restore Successfully");
            }




        }
    }
}
