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
using ServiceRequestInformationSystem.UserForm;

namespace ServiceRequestInformationSystem
{
    public partial class ucArchivedInspection : UserControl
    {
        public ucArchivedInspection()
        {
            InitializeComponent();
            //  LoadRequestList();
            //DataGridViewDesign();
        }

        private void DataGridViewDesign()
        {


            this.dataGridView_ListOfInspection.Columns["Requesting Office"].Width = 250;
            this.dataGridView_ListOfInspection.Columns["Requested By"].Width = 150;
            this.dataGridView_ListOfInspection.Columns["Receive By"].Width = 75;
            this.dataGridView_ListOfInspection.Columns["Receive Date"].Width = 115;
            this.dataGridView_ListOfInspection.Columns["Type Of Unit"].Width = 115;
            this.dataGridView_ListOfInspection.Columns["Complaint On Unit"].Width = 250;
            this.dataGridView_ListOfInspection.Columns["Property No"].MinimumWidth = 250;
           



            dataGridView_ListOfInspection.BorderStyle = BorderStyle.None;
            dataGridView_ListOfInspection.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_ListOfInspection.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_ListOfInspection.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_ListOfInspection.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_ListOfInspection.BackgroundColor = Color.White;

            dataGridView_ListOfInspection.EnableHeadersVisualStyles = false;
            dataGridView_ListOfInspection.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_ListOfInspection.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_ListOfInspection.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        public void LoadRequestList()
        {
            try
            {



                SQLCon.DbCon();
                SQLCon.sqlDataApater = new SqlDataAdapter(
             @"SELECT
                    T1.II_ID, 
                    T1.RequestingOffice AS [Requesting Office], 
                    T1.RequestedBy AS [Requested By],  
                    T1.ReceiveBy AS [Receive By], 
                    T1.Position AS [Position],
                    T1.ReceiveDate AS [Receive Date],
              
                    T1.TypeOfUnit AS [Type Of Unit],
                    T1.ComplaintOnUnit AS [Complaint On Unit],
                    T1.PropertyNumber AS [Property No]
                   
                FROM 
                    InspectionInfoes AS T1            
                  
                    ", SQLCon.sqlConnection);
               
                SQLCon.dataTable = new DataTable();
                SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                dataGridView_ListOfInspection.DataSource = SQLCon.dataTable;
                dataGridView_ListOfInspection.Columns["II_ID"].Visible = false;
                dataGridView_ListOfInspection.Columns["Position"].Visible = false;

                DataGridViewDesign();

                int i = 0;
                foreach (DataGridViewRow row in dataGridView_ListOfInspection.Rows)
                {
                    i++;
                }
                label_Counter.Text = i.ToString();

            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
            }
        }

        private static ucArchivedInspection _instance;
        public static ucArchivedInspection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucArchivedInspection();

                return _instance;
            }
        }

        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadRequestList();


                tb_Search.ForeColor = Color.LightGray;

            }
        }

        private void ucArchived_VisibleChanged(object sender, EventArgs e)
        {
            LoadRequestList();
        }



        private void tb_Search_Leave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "SEARCH NAME OR OFFICE";
                tb_Search.ForeColor = Color.DimGray;
            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            tb_Search.Text = "";
            LoadRequestList();
            tb_Search.Text = "SEARCH NAME OR OFFICE";
        }

        private void dataGridView_ListOfRequest_DoubleClick(object sender, EventArgs e)
        {

            UpdateInspectionArchived updateInspectionArchived = new UpdateInspectionArchived();
            UpdateInspectionArchived.dgvr_UpdateArchiveInspection = dataGridView_ListOfInspection.SelectedRows[0];
            updateInspectionArchived.ShowDialog();


            LoadRequestList();

        }

        private void tb_Search_Enter(object sender, EventArgs e)
        {
            if (tb_Search.Text == "SEARCH NAME OR OFFICE")
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.LightGray;
            }
        }

        private void tb_Search_Leave_1(object sender, EventArgs e)
        {

        }

        private void ucArchivedInspection_Load(object sender, EventArgs e)
        {

        }
    }
}
