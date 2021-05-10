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
    public partial class RecommendationForm : Form
    {
        public RecommendationForm()
        {
            InitializeComponent();
        }

        private void bt_AddRecommendation_Click(object sender, EventArgs e)
        {
            dataGridView_Recommendation.Rows.Add(cb_Recommendation.Text);
        }
    }
}
