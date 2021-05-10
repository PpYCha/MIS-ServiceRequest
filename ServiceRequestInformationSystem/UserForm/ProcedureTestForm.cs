using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem.UserForm
{
    public partial class ProcedureTestForm : Form
    {
        public ProcedureTestForm()
        {
            InitializeComponent();
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_AddProcedure_Click(object sender, EventArgs e)
        {
            dataGridView_ProcedureTest.Rows.Add(cb_ProcedureTest.Text);
        }
    }
}
