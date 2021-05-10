using ServiceRequestInformationSystem.Models;
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

namespace ServiceRequestInformationSystem.UserForm
{
    public partial class UpdateInspectionArchived : Form
    {
        public UpdateInspectionArchived()
        {
            InitializeComponent();
        }
        public static DataGridViewRow dgvr_UpdateArchiveInspection;
        private static int tempIdRequest;
        private static bool isUpdateUS = false;

        private void UpdateInspectionArchived_Load(object sender, EventArgs e)
        {
           

            LoadUnitSpecification();
            LoadProcedureTest();
            LoadParticular();
            LoadRecommendation();
            LoadInpectedBy();

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

            PopulateComboBox("FindingParticulars", "FP_ID", "Status", cb_Particular);
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

            tempIdRequest = Convert.ToInt32(dgvr_UpdateArchiveInspection.Cells[0].Value.ToString());
            cb_RequestingOffice.Text = dgvr_UpdateArchiveInspection.Cells[1].Value.ToString();
            cb_RequestedBy.Text = dgvr_UpdateArchiveInspection.Cells[2].Value.ToString();
            cb_ReceivedBy.Text = dgvr_UpdateArchiveInspection.Cells[3].Value.ToString();
            comboBox1.Text = dgvr_UpdateArchiveInspection.Cells[4].Value.ToString();
            dateTimePicker_Received.Value = Convert.ToDateTime(dgvr_UpdateArchiveInspection.Cells[5].Value.ToString());
            cb_TypeOfUnit.Text = dgvr_UpdateArchiveInspection.Cells[6].Value.ToString();
            cb_ComplaintOnUnit.Text = dgvr_UpdateArchiveInspection.Cells[7].Value.ToString();
            cb_PropertyNo.Text = dgvr_UpdateArchiveInspection.Cells[8].Value.ToString();
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

        private void LoadInpectedBy()
        {
            using (SrisContext ctx = new SrisContext())
            {
                var inspectedList = from p in ctx.InspectedPerformedBy
                                         where p.II_ID == tempIdRequest
                                         select new
                                         {
                                             hr = p.Name,
                                             r = p.Position

                                         };
                foreach (var item in inspectedList)
                {
                    dataGridView_PerformedInspected.Rows.Add(item.hr, item.r);
                }
            }
        }

        private void LoadRecommendation()
        {
            using (SrisContext ctx = new SrisContext())
            {
                var recommendationList = from p in ctx.Recommendation
                                     where p.II_ID == tempIdRequest
                                     select new
                                     {
                                         hr = p.RecommendationDetails,
                                       
                                     };
                foreach (var item in recommendationList)
                {
                    dataGridView_Recommendation.Rows.Add(item.hr);
                }
            }
        }

        private void LoadParticular()
        {
            using (SrisContext ctx = new SrisContext())
            {
                var particularList = from p in ctx.FindingParticular
                                        where p.II_ID == tempIdRequest
                                        select new
                                        {
                                            hr = p.Particulars,
                                            r = p.InspectionInfo
                                        };
                foreach (var item in particularList)
                {
                    dataGridView_FindingParticular.Rows.Add(item.hr, item.r);
                }
            }
        }

        private void LoadProcedureTest()
        {
            using (SrisContext ctx = new SrisContext())
            {
                var procedureTestList = from p in ctx.ProcedureTest
                                            where p.II_ID == tempIdRequest
                                            select new
                                            {
                                                hr = p.ProcedureTestDetails,
                                             
                                            };
                foreach (var item in procedureTestList)
                {
                    dataGridView_ProcedureTest.Rows.Add(item.hr);
                }
            }
        }

        private void LoadUnitSpecification()
        {
            using (SrisContext ctx = new SrisContext())
            {
                var unitSpecificationList = from p in ctx.UnitSpecification
                                            where p.II_ID == tempIdRequest
                                            select new
                                            {
                                                hr = p.HardwareComponent,
                                                r = p.Remarks
                                            };
                foreach (var item in unitSpecificationList)
                {
                    dataGridView_UnitSpecs.Rows.Add(item.hr, item.r);
                }
            }

            //SQLCon.DbCon();
            //SQLCon.sqlDataApater = new SqlDataAdapter(
            //   @"SELECT
            //        T1.HardwareComponent AS [Component],
            //        T1.Remarks AS [Description]

            //    FROM
            //      UnitSpecifications AS T1

            //    WHERE
            //        T1.II_ID = @0
            //      ", SQLCon.sqlConnection);
            //SQLCon.sqlDataApater.SelectCommand.Parameters.AddWithValue("@0", tempIdRequest);
            //SQLCon.dataTable = new DataTable();
            //SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            //dataGridView_UnitSpecs.DataSource = SQLCon.dataTable;
        }

        private void bt_UnitSpecification_Click(object sender, EventArgs e)
        {
            if (isUpdateUS == true)
            {
                dataGridView_UnitSpecs.SelectedRows[0].Cells[0].Value = cb_HardwareComponents.Text;
                dataGridView_UnitSpecs.SelectedRows[0].Cells[1].Value = cb_ComponentRemarks.Text;
                isUpdateUS = false;
            }
           else
            {
                dataGridView_UnitSpecs.Rows.Add(cb_HardwareComponents.Text, cb_ComponentRemarks.Text);
            }
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            using (SrisContext ctx = new SrisContext())
            {

                //var unitSpecification = new UnitSpecification();
                //foreach (DataGridViewRow row in dataGridView_UnitSpecs.Rows)
                //{
                //    unitSpecification.HardwareComponent = row.Cells["Column2"].Value.ToString();
                //    unitSpecification.Remarks = row.Cells["Column3"].Value.ToString();
                //    unitSpecification.II_ID = tempIdRequest;
                //    ctx.UnitSpecification.Add(unitSpecification);
                //    ctx.SaveChanges();
                //}


                var unitSpecificationUpdate = new UnitSpecification();
                foreach (DataGridViewRow itemUnitSpecification in dataGridView_UnitSpecs.Rows)
                {
                    string hardWareComponents = itemUnitSpecification.Cells["Column2"].Value.ToString();
                    string hardwareRemarks = itemUnitSpecification.Cells["Column3"].Value.ToString();

                    if (!(ctx.UnitSpecification.Any(x => x.II_ID == tempIdRequest && x.HardwareComponent == hardWareComponents && x.Remarks == hardwareRemarks)))
                    {
                        unitSpecificationUpdate.HardwareComponent = itemUnitSpecification.Cells["Column2"].Value.ToString();
                        unitSpecificationUpdate.Remarks = itemUnitSpecification.Cells["Column3"].Value.ToString();
                        unitSpecificationUpdate.II_ID = tempIdRequest;
                        ctx.UnitSpecification.Add(unitSpecificationUpdate);
                        ctx.SaveChanges();
                    }else
                    {
                        var usID = ctx.UnitSpecification.Where(x => x.II_ID == tempIdRequest && x.HardwareComponent == hardWareComponents && x.Remarks == hardwareRemarks).Select(p => p.US_ID).FirstOrDefault().ToString();
                        unitSpecificationUpdate.HardwareComponent = itemUnitSpecification.Cells["Column2"].Value.ToString();
                        unitSpecificationUpdate.Remarks = itemUnitSpecification.Cells["Column3"].Value.ToString();
                        unitSpecificationUpdate.II_ID = tempIdRequest;
                        unitSpecificationUpdate.US_ID = Int32.Parse(usID);
                        ctx.UnitSpecification.Attach(unitSpecificationUpdate);
                        ctx.Entry(unitSpecificationUpdate).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
            }
            }
        }

        private void dataGridView_UnitSpecs_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_UnitSpecs.SelectedRows.Count > 0) 
            {
                cb_HardwareComponents.Text = dataGridView_UnitSpecs.SelectedRows[0].Cells["Column2"].Value.ToString();
                cb_ComponentRemarks.Text = dataGridView_UnitSpecs.SelectedRows[0].Cells["Column2"].Value.ToString();
                isUpdateUS = true;
            }
        }
    }
}
