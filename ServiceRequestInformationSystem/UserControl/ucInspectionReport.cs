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
using ServiceRequestInformationSystem.Models;
using System.ComponentModel.Design.Data;
using ServiceRequestInformationSystem.UserForm;
using System.Diagnostics;

namespace ServiceRequestInformationSystem
{
    public partial class ucInspectionReport : UserControl
    {

       
        public ucInspectionReport()
        {
            InitializeComponent();
      
        }

        private static bool update = false;

        private static ucInspectionReport _instance;
        public static ucInspectionReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucInspectionReport();

                return _instance;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Procedures_Click(object sender, EventArgs e)
        {
            ProcedureTestForm procedureTestForm = new ProcedureTestForm();
            procedureTestForm.ShowDialog();
        }

        private void bt_Particulars_Click(object sender, EventArgs e)
        {
            FindingParticularForm findingParticularForm = new FindingParticularForm();
            findingParticularForm.ShowDialog();
        }

        private void bt_Recommendation_Click(object sender, EventArgs e)
        {
            RecommendationForm recommendationForm = new RecommendationForm();
            recommendationForm.ShowDialog();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveInspectionReport();
            ClearText();
        }

        private void SaveInspectionReport()
        {

            // Add InspectionInfoes
            SQLCon.DbCon();

            SQLCon.sqlCommand = new SqlCommand(
                        @"INSERT INTO InspectionInfoes (RequestingOffice, RequestedBy, ReceiveBy, ReceiveDate, TypeOfUnit, ComplaintOnUnit, PropertyNumber, Position)  VALUES(
                        @RequestingOffice,
                        @RequestedBy,
                        @ReceiveBy,
                        @ReceiveDate,
                        @TypeOfUnit,
                        @ComplaintOnUnit,
                        @PropertyNumber,
                        @Position
                        ); SELECT SCOPE_IDENTITY();", SQLCon.sqlConnection);

            SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@RequestingOffice", cb_RequestingOffice.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@RequestedBy", cb_RequestedBy.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@ReceiveBy", cb_ReceivedBy.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@ReceiveDate", dateTimePicker_Received.Value.Date);
                SQLCon.sqlCommand.Parameters.AddWithValue("@TypeOfUnit", cb_TypeOfUnit.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@ComplaintOnUnit", cb_ComplaintOnUnit.Text);
                SQLCon.sqlCommand.Parameters.AddWithValue("@PropertyNumber", cb_PropertyNo.Text);
            SQLCon.sqlCommand.Parameters.AddWithValue("@Position", cb_Position.Text);
            int insertedID = Convert.ToInt32(SQLCon.sqlCommand.ExecuteScalar());
            // SQLCon.sqlCommand.ExecuteNonQuery();

            //Add Unit Specification
            foreach (DataGridViewRow row in dataGridView_UnitSpecs.Rows)
            {
                SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO UnitSpecifications (HardwareComponent, Remarks, II_ID) VALUES(
            @HardwareComponent,
            @Remarks,
            @II_ID
            );", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@HardwareComponent", row.Cells["Column_Components"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@Remarks", row.Cells["Column_Remarks"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@II_ID", insertedID);
                SQLCon.sqlCommand.ExecuteNonQuery();
            }
          

            //ProcedureTests
            foreach (DataGridViewRow row in dataGridView_ProcedureTest.Rows)
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO ProcedureTests (ProcedureTestDetails, II_ID) VALUES(
                @ProcedureTestDetails,
                @II_ID
                );", SQLCon.sqlConnection);

                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@ProcedureTestDetails", row.Cells["Column1"].Value.ToString());

                SQLCon.sqlCommand.Parameters.AddWithValue("@II_ID", insertedID);

                SQLCon.sqlCommand.ExecuteNonQuery();
            }

            //ParticularFindings
            foreach (DataGridViewRow row in dataGridView_FindingParticular.Rows)
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO FindingParticulars (Particulars, Status, II_ID) VALUES(
                @Particulars,
                @Status,
                @II_ID
                );", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@Particulars", row.Cells["Column_Particular"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@Status", row.Cells["Column_Findings"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@II_ID", insertedID);
                SQLCon.sqlCommand.ExecuteNonQuery();
            }

            //Recommendations
            foreach (DataGridViewRow row in dataGridView_Recommendation.Rows)
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO Recommendations (RecommendationDetails, II_ID) VALUES(
                @RecommendationDetails,
                @II_ID
                );", SQLCon.sqlConnection);

                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@RecommendationDetails", row.Cells["Column_Recommendations"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@II_ID", insertedID);
                SQLCon.sqlCommand.ExecuteNonQuery();
            }

            //Performed Inspected
            foreach (DataGridViewRow row in dataGridView_PerformedInspected.Rows)
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO InspectedPerformedBies (Name, Position, II_ID) VALUES(
                @Name,
                @Position,
                @II_ID
                );", SQLCon.sqlConnection);

                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@Name", row.Cells["Column_Name"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@Position", row.Cells["Column_Position"].Value.ToString());
                SQLCon.sqlCommand.Parameters.AddWithValue("@II_ID", insertedID);
                SQLCon.sqlCommand.ExecuteNonQuery();
            }


            PopulateComboBox_Infoes();
            MetroFramework.MetroMessageBox.Show(this, "Report Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ucInspectionReport_Load(object sender, EventArgs e)
        {
            PopulateComboBox_Infoes();


            DesignDataGridView(dataGridView_UnitSpecs);
            DesignDataGridView(dataGridView_ProcedureTest);
            DesignDataGridView(dataGridView_FindingParticular);
            DesignDataGridView(dataGridView_Recommendation);
            DesignDataGridView(dataGridView_PerformedInspected);
        }

        private void DesignDataGridView(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void tb_RequestiongOffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            PopulateComboBox_Infoes();
        }

        private void PopulateComboBox_Infoes()
        {
       
            PopulateComboBox("OfficeDepartments", "OD_ID", "OfficeDepartmentName", cb_RequestingOffice);
            PopulateComboBox("ServiceRequestInfoes", "SR_ID", "RequestedBy", cb_RequestedBy);

            // PopulateComboBox("ServiceProvidedBies", "SP_ID", "spName", cb_ReceivedBy);

            using (SrisContext ctx = new SrisContext())
            {
                var spNameList = ctx.ServiceProvidedBy.Where(x => x.IsActive == true).ToList();
                cb_ReceivedBy.DataSource = spNameList;
                //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                cb_ReceivedBy.DisplayMember = "spName";
                cb_ReceivedBy.ValueMember = "SP_ID";
                cb_ReceivedBy.SelectedIndex = -1;
                cb_ReceivedBy.SelectionLength = 0;
              
              
            }
           

            PopulateComboBox("InspectionInfoes", "II_ID", "ComplaintOnUnit", cb_ComplaintOnUnit);
            PopulateComboBox("InspectionInfoes", "II_ID", "TypeOfUnit", cb_TypeOfUnit);
            PopulateComboBox("InspectionInfoes", "II_ID", "PropertyNumber", cb_PropertyNo);

            PopulateComboBox("UnitSpecifications", "US_ID", "HardwareComponent", cb_HardwareComponents);
            PopulateComboBox("UnitSpecifications", "US_ID", "Remarks", cb_ComponentRemarks);

            PopulateComboBox("ProcedureTests", "PT_ID", "ProcedureTestDetails", cb_ProcedureTest);

            PopulateComboBox("FindingParticulars", "FP_ID", "Status", cb_Particular );
            PopulateComboBox("FindingParticulars", "FP_ID", "Particulars", cb_Finding);

            PopulateComboBox("Recommendations", "R_ID", "RecommendationDetails", cb_Recommendation);

            //PopulateComboBox("ServiceProvidedBies", "SP_ID", "spName", cb_NamePerformedInspected);
            using (SrisContext ctx = new SrisContext())
            {
                var spNameList = ctx.ServiceProvidedBy.Where(x => x.IsActive == true && x.spPosition != "PROGRAMMER").ToList();
                cb_NamePerformedInspected.DataSource = spNameList;
                //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                cb_NamePerformedInspected.DisplayMember = "spName";
                cb_NamePerformedInspected.ValueMember = "SP_ID";
                cb_NamePerformedInspected.SelectedIndex = -1;
                cb_NamePerformedInspected.SelectionLength = 0;
               

            }

        }

        public void PopulateComboBox(string tableName, string valueName, string displayName, ComboBox cb_Name)
        {
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT DISTINCT " + displayName + " FROM " + tableName + " ORDER BY " + displayName, SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_Name.DataSource = SQLCon.dataTable;
            //   cb_Name.ValueMember = valueName;
            cb_Name.DisplayMember = displayName;
            cb_Name.AutoCompleteMode = AutoCompleteMode.Append;
            cb_Name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Name.SelectedIndex = -1;
        }

        private void bt_SaveProcedure_Click(object sender, EventArgs e)
        {
            AddUpdateDataGridViewRows(dataGridView_ProcedureTest, cb_ProcedureTest, cb_MagicBox );
            cb_MagicBox.Text = "MagicBox";
        }

        private void bt_SaveRecommendation_Click(object sender, EventArgs e)
        {
            AddUpdateDataGridViewRows(dataGridView_Recommendation, cb_Recommendation, cb_MagicBox);
            cb_MagicBox.Text = "MagicBox";
        }

        private void bt_SaveParticularFinding_Click(object sender, EventArgs e)
        {
            AddUpdateDataGridViewRows(dataGridView_FindingParticular, cb_Particular, cb_Finding);
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            RptInspectionReport rptInspectionReport = new RptInspectionReport();
            rptInspectionReport.ShowDialog();
           
        }

        private void bt_UnitSpecification_Click(object sender, EventArgs e)
        {

           AddUpdateDataGridViewRows(dataGridView_UnitSpecs, cb_HardwareComponents, cb_ComponentRemarks);

         
        }

        private void AddUpdateDataGridViewRows(DataGridView dataGridView ,ComboBox cb1, ComboBox cb2)
        {
            if (!(String.IsNullOrEmpty(cb1.Text) || String.IsNullOrEmpty(cb2.Text)))
            {
                if (update)
                {
                    dataGridView.SelectedRows[0].Cells[0].Value = cb1.Text;
                    dataGridView.SelectedRows[0].Cells[1].Value = cb2.Text;
                    update = false;
                }
                else
                {
                    dataGridView.Rows.Add(cb1.Text, cb2.Text);
                }

                //cb1.SelectedIndex = -1;
                //cb2.SelectedIndex = -1;
                cb1.Text = "";
                cb2.Text = "";
            }
        }

        private void ClearText()
        {
            cb_RequestingOffice.SelectedIndex = -1;
            cb_RequestedBy.SelectedIndex = -1;
            cb_ReceivedBy.SelectedIndex = -1;
            cb_Position.SelectedIndex = -1;

            cb_TypeOfUnit.SelectedIndex = -1;
            cb_PropertyNo.SelectedIndex = -1;
            cb_ComplaintOnUnit.SelectedIndex = -1;

            cb_ComponentRemarks.SelectedIndex = -1;
            cb_ComponentRemarks.SelectedIndex = -1;
            cb_Finding.SelectedIndex = -1;
            cb_Particular.SelectedIndex = -1;
            cb_Recommendation.SelectedIndex = -1;
            cb_ProcedureTest.SelectedIndex = -1;

            RemoveAllDataGridView(dataGridView_UnitSpecs);
            RemoveAllDataGridView(dataGridView_ProcedureTest);
            RemoveAllDataGridView(dataGridView_FindingParticular);
            RemoveAllDataGridView(dataGridView_Recommendation);
            RemoveAllDataGridView(dataGridView_PerformedInspected);
        }

        private void RemoveAllDataGridView(DataGridView row)
        {
            //foreach (DataGridViewRow item in row.Rows)
            //{
            //    row.Rows.Remove(item);
            //}
            row.Rows.Clear();
        }

        private void cb_SavePI_Click(object sender, EventArgs e)
        {
            AddUpdateDataGridViewRows(dataGridView_PerformedInspected, cb_NamePerformedInspected, cb_Position);
        }

        private void cb_RequestingOffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_RequestedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ReceivedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_TypeOfUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_PropertyNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ComplaintOnUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_HardwareComponents_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ComponentRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ProcedureTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Particular_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Finding_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Recommendation_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_NamePerformedInspected_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Position_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void dataGridView_UnitSpecs_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_UnitSpecs.SelectedRows.Count > 0)
            {
                
                cb_HardwareComponents.Text = dataGridView_UnitSpecs.SelectedRows[0].Cells["Column_Components"].Value.ToString();
                cb_ComponentRemarks.Text = dataGridView_UnitSpecs.SelectedRows[0].Cells["Column_Remarks"].Value.ToString();
                update = true;
            }
        }

        private void bt_RemoveUS_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(dataGridView_UnitSpecs, cb_HardwareComponents, cb_ComponentRemarks);

        }

        private void RemoveDatagridviewRow(DataGridView dataGridView, ComboBox cb1, ComboBox cb2)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
            }

            try
            {
                cb1.SelectedIndex = -1;
                cb2.SelectedIndex = -1;
            }
            catch (Exception x)
            {
                Debug.WriteLine(x);
            }
         
        }

        private void bt_RemovePT_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(dataGridView_ProcedureTest, cb_ProcedureTest, null);
        }

        private void bt_RemovePF_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(dataGridView_FindingParticular, cb_Finding, cb_Particular);
        }

        private void bt_RemoveR_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(dataGridView_Recommendation, cb_Recommendation, null);
        }

        private void bt_RemovePI_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(dataGridView_PerformedInspected, cb_NamePerformedInspected, cb_Position);
        }

        private void cb_NamePerformedInspected_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SrisContext ctx = new SrisContext())
            {
                var pos = ctx.ServiceProvidedBy.Where(x => x.spName == cb_NamePerformedInspected.Text && x.IsActive == true).Select(p => p.spPosition);
                cb_Position.Text = pos.FirstOrDefault();
            }
           
        }

        private void cb_ReceivedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SrisContext ctx = new SrisContext())
                {
              

                    var pos = ctx.ServiceProvidedBy.Where(x => x.spName == cb_ReceivedBy.Text).Select( p => p.spPosition);

                    comboBox1.Text = pos.FirstOrDefault();
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
