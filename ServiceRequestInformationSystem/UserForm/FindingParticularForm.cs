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
    public partial class FindingParticularForm : Form
    {
        public FindingParticularForm()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {

            dataGridView_FindingParticular.Rows.Add(cb_Finding.Text, cb_Particular.Text);
        }
    }
}
