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
    public partial class ucArchived : UserControl
    {
        public ucArchived()
        {
            InitializeComponent();
          //  LoadRequestList();
            //DataGridViewDesign();
        }

        private void DataGridViewDesign()
        {
         

            this.dataGridView_ListOfRequest.Columns["Type Of Service Provided"].Width = 250;
            this.dataGridView_ListOfRequest.Columns["Requested By"].Width = 150;
            this.dataGridView_ListOfRequest.Columns["Office"].Width = 75;
            this.dataGridView_ListOfRequest.Columns["Date Requested"].Width = 115;
            this.dataGridView_ListOfRequest.Columns["Date Requested"].Width = 115;
            this.dataGridView_ListOfRequest.Columns["Remarks"].Width = 250;
            this.dataGridView_ListOfRequest.Columns["Technicians"].MinimumWidth = 250;
            this.dataGridView_ListOfRequest.Columns["Technicians"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dataGridView_ListOfRequest.BorderStyle = BorderStyle.None;
            dataGridView_ListOfRequest.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_ListOfRequest.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_ListOfRequest.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_ListOfRequest.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_ListOfRequest.BackgroundColor = Color.White;

            dataGridView_ListOfRequest.EnableHeadersVisualStyles = false;
            dataGridView_ListOfRequest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        public void LoadRequestList()
        {
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT DISTINCT
                    T1.SR_ID, 
                    T2.TypeOfServiceProvided AS [Type Of Service Provided], 
                    T1.RequestedBy AS [Requested By],  
                    T3.OfficeDepartmentName AS [Office], 
                    T1.DateRequested AS [Date Requested],
              
                    T1.DateAccomplished AS [Date Accomplished],
                    Remars AS [Remarks],
                    T1.Techinicians AS [Technicians]
                   
                FROM 
                    ServiceRequestInfoes AS T1, 
                    TypeOfServices AS T2, 
                    OfficeDepartments AS T3, 
                    ServiceProvidedBies AS T4, 
                    RemarkInfoes AS T5
                WHERE 
                    T1.Status = 1  AND
                    T1.TS_ID=T2.TS_ID AND 
                    T1.OD_ID=T3.OD_ID AND 
                    T1.Remark_ID=T5.Remark_ID AND
                    (
                    T1.RequestedBy LIKE @1 OR
                    T3.OfficeDepartmentName LIKE @2
                    )", SQLCon.sqlConnection);
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@1", "%" + tb_Search.Text + "%");
            SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@2", "%" + tb_Search.Text + "%");
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            dataGridView_ListOfRequest.DataSource = SQLCon.dataTable;
            dataGridView_ListOfRequest.Columns["SR_ID"].Visible = false;
            dataGridView_ListOfRequest.Columns["Date Accomplished"].Visible = false;

            DataGridViewDesign();

            int i = 0;
            foreach (DataGridViewRow row in dataGridView_ListOfRequest.Rows)
            {
                i++;
            }
            label_Counter.Text = i.ToString();
        }

        private static ucArchived _instance;
        public static ucArchived Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucArchived();

                return _instance;
            }
        }

        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadRequestList();

            }
        }

        private void ucArchived_VisibleChanged(object sender, EventArgs e)
        {
            LoadRequestList();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Focus();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (tb_Search.TextLength > 0)
            {
                label2.Hide();
            }
            else
            {
                label2.Show();
            }
        }
    }
}
