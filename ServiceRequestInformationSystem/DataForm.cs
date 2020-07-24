using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class DataForm : MetroFramework.Forms.MetroForm
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataGridViewDesign()
        {
            this.dataGridView_ListData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView_ListData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_ListData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_ListData.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_ListData.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_ListData.BackgroundColor = Color.White;

            dataGridView_ListData.EnableHeadersVisualStyles = false;
            dataGridView_ListData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_ListData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_ListData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
      
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            tb_Services.Clear();
            tb_Department.Clear();
            tb_Technician.Clear();
            tb_Remarks.Clear();
            errorProvider.Clear();
        }

        private void bt_AddServices_Click(object sender, EventArgs e)
        {
            errorProvider.Tag = "AddServices";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddUpdateData("TypeOfServices", "TypeOfServiceProvided", tb_Services, "Service", "TS_ID");
                LoadDataList("TypeOfServices", "TypeOfServiceProvided", "TS_ID", "Services");
            }

        }
        private void bt_AddDepartment_Click(object sender, EventArgs e)
        {
            errorProvider.Tag = "AddDepartment";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddUpdateData("OfficeDepartments", "OfficeDepartmentName", tb_Department, "Department", "OD_ID");
                LoadDataList("OfficeDepartments", "OfficeDepartmentName", "OD_ID", "Departments");
            }
        }

        private void bt_AddTechinician_Click(object sender, EventArgs e)
        {
            errorProvider.Tag = "AddTechnician";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddUpdateData("ServiceProvidedBies", "spName", tb_Technician, "Technician", "SP_ID");
                LoadDataList("ServiceProvidedBies", "spName", "SP_ID", "Technicians");
            }

        }

        private void bt_AddRemarks_Click(object sender, EventArgs e)
        {
            errorProvider.Tag = "AddRemarks";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddUpdateData("RemarkInfoes", "Remars", tb_Remarks, "Remarks", "Remark_ID");
                LoadDataList("RemarkInfoes", "Remars", "Remark_ID", "Remarks");
            }
        }

        private void AddUpdateData(string tableName, string columnName, TextBox tbName, string message, string id)
        {
            if (dataGridView_ListData.SelectedRows.Count <= 0)
            {
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand("INSERT INTO " + tableName + " VALUES (@1, @2)", SQLCon.sqlConnection);
                SQLCon.sqlCommand.Parameters.AddWithValue("@1", tbName.Text.ToUpper());
                SQLCon.sqlCommand.Parameters.AddWithValue("@2", 1);
                SQLCon.sqlCommand.ExecuteNonQuery();
                MessageBox.Show("New " + message + " Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int tempId = int.Parse(dataGridView_ListData.SelectedRows[0].Cells[0].Value.ToString());
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand("UPDATE " + tableName + " SET " + columnName + " = @1 WHERE " + id + " = @0", SQLCon.sqlConnection);
                SQLCon.sqlCommand.CommandType = CommandType.Text;
                SQLCon.sqlCommand.Parameters.AddWithValue("@0", tempId);
                SQLCon.sqlCommand.Parameters.AddWithValue("@1", tbName.Text.ToUpper());
                SQLCon.sqlCommand.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, message + " Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ClearText();
        }


        private void bt_ServiceList_Click(object sender, EventArgs e)
        {
            LoadDataList("TypeOfServices", "TypeOfServiceProvided", "TS_ID", "Services");
        }

        private void bt_DeparmentList_Click(object sender, EventArgs e)
        {
            LoadDataList("OfficeDepartments", "OfficeDepartmentName", "OD_ID", "Departments");
        }

        private void bt_TechnicianList_Click(object sender, EventArgs e)
        {
            LoadDataList("ServiceProvidedBies", "spName", "SP_ID", "Technicians");
        }

        private void bt_RemarksList_Click(object sender, EventArgs e)
        {
            LoadDataList("RemarkInfoes", "Remars", "Remark_ID", "Remarks");
        }

        private void LoadDataList(string tableName, string columnName, string id, string tag)
        {
            SQLCon.DbCon();
            string columnTableName = columnName;
            columnTableName = Regex.Replace(columnTableName, "([a-z])([A-Z])", "$1 $2").Trim();
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT " + id + ", " + columnName + " AS [" + columnTableName + "] FROM " + tableName + " WHERE IsActive = 1", SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            dataGridView_ListData.DataSource = SQLCon.dataTable;
            dataGridView_ListData.Columns[0].Visible = false;
            dataGridView_ListData.Columns[1].HeaderText = tag.ToUpper();
            dataGridView_ListData.Tag = tag;
            ClearText();
            DataGridViewDesign();
            dataGridView_ListData.ClearSelection();
        }

        private void dataGridView_ListData_DoubleClick(object sender, EventArgs e)
        {
            ClearText();
            try
            {

            if (dataGridView_ListData.Tag == "Services")
            {
                tb_Services.Text = dataGridView_ListData.SelectedRows[0].Cells[1].Value.ToString();
            }
            if (dataGridView_ListData.Tag == "Departments")
            {
                tb_Department.Text = dataGridView_ListData.SelectedRows[0].Cells[1].Value.ToString();
            }
            if (dataGridView_ListData.Tag == "Technicians")
            {
                tb_Technician.Text = dataGridView_ListData.SelectedRows[0].Cells[1].Value.ToString();
            }
            if (dataGridView_ListData.Tag == "Remarks")
            {
                tb_Remarks.Text = dataGridView_ListData.SelectedRows[0].Cells[1].Value.ToString();
            }
            bt_Delete.Enabled = Enabled;
            }
            catch (Exception)
            {

               
            }
        }

        //Start Validating Region
        private void tb_Services_Validating(object sender, CancelEventArgs e)
        {
            if ((tb_Services.Text == "" && errorProvider.Tag == "AddServices") || (tb_Services.Text != "" && errorProvider.Tag == "AddServices"))
            {
                CheckifExist("TypeOfServiceProvided", "TypeOfServices", "Service", tb_Services, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_Services, null);
            }

        }

        private void tb_Department_Validating(object sender, CancelEventArgs e)
        {
            if ((tb_Department.Text == "" && errorProvider.Tag == "AddDepartment") || (tb_Department.Text != "" && errorProvider.Tag == "AddDepartment"))
            {
                CheckifExist("OfficeDepartmentName", "OfficeDepartments", "Department", tb_Department, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_Department, null);
            }
        }

        private void bt_AddTechinician_Validating(object sender, CancelEventArgs e)
        {
            if (errorProvider.Tag == "AddTechnician")
            {
                CheckifExist("spName", "ServiceProvidedBies", "Technician", tb_Technician, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_Technician, null);
            }
        }

        private void bt_AddRemarks_Validating(object sender, CancelEventArgs e)
        {
            if (errorProvider.Tag == "AddRemarks")
            {
                CheckifExist("Remars", "RemarkInfoes", "Remark", tb_Remarks, e);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_Remarks, null);
            }
        }

        private void CheckifExist(string columnName, string tableName, string input, TextBox tb, CancelEventArgs e)
        {
            int exist = 0;
            SQLCon.DbCon();
            SQLCon.sqlCommand = new SqlCommand("SELECT ISNULL(" + columnName + ",0) FROM " + tableName + " WHERE (" + columnName + "= @service)", SQLCon.sqlConnection);
            SQLCon.sqlCommand.Parameters.AddWithValue("@service", tb.Text);
            SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();
            if (SQLCon.sqlDataReader.Read())
                exist = 1;
            if (exist > 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb, input + " name already exist");
            }
            else if (tb.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(tb, "Please input a " + input + "!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb, null);
            }
        }
        //End of Validating Region

        private void DataForm_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView_ListData.ClearSelection();
        }

        private void dataGridView_ListData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListData.Tag == "Services")
            {
                DeleteUpdateDataList("TypeOfServices", "TypeOfServiceProvided", "TS_ID" ,"Services");
            }
            if (dataGridView_ListData.Tag == "Departments")
            {
                DeleteUpdateDataList("OfficeDepartments", "OfficeDepartmentName", "OD_ID" , "Departments");
            }
            if (dataGridView_ListData.Tag == "Technicians")
            {
                DeleteUpdateDataList("ServiceProvidedBies", "spName", "SP_ID" ,"Technicians");
            }
            if (dataGridView_ListData.Tag == "Remarks")
            {
                DeleteUpdateDataList("RemarkInfoes", "Remars", "Remark_ID" ,"Remarks");
            }

        }

        private void DeleteUpdateDataList(string tableName, string columnName  ,string id, string tag)
        {

            if (dataGridView_ListData.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select " + tag + " ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int tempId = int.Parse(dataGridView_ListData.SelectedRows[0].Cells[0].Value.ToString());
                SQLCon.DbCon();
                SQLCon.sqlCommand = new SqlCommand("UPDATE " + tableName + " SET IsActive = 1 WHERE " + id + " = @2", SQLCon.sqlConnection);
                SQLCon.sqlCommand.Parameters.AddWithValue("@2", tempId);
                SQLCon.sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted " + tag + " ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataList(tableName, columnName, id, tag);
            }
            
            
        }

        private void tb_Services_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider.Tag = "AddServices";
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    AddUpdateData("TypeOfServices", "TypeOfServiceProvided", tb_Services, "Service", "TS_ID");
                    LoadDataList("TypeOfServices", "TypeOfServiceProvided", "TS_ID", "Services");
                }
            }
        }

        private void tb_Department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider.Tag = "AddDepartment";
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    AddUpdateData("OfficeDepartments", "OfficeDepartmentName", tb_Department, "Department", "OD_ID");
                    LoadDataList("OfficeDepartments", "OfficeDepartmentName", "OD_ID", "Departments");
                }
            }
        }

        private void tb_Technician_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider.Tag = "AddTechnician";
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    AddUpdateData("ServiceProvidedBies", "spName", tb_Technician, "Technician", "SP_ID");
                    LoadDataList("ServiceProvidedBies", "spName", "SP_ID", "Technicians");
                }
            }
        }

        private void tb_Remarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider.Tag = "AddRemarks";
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    AddUpdateData("RemarkInfoes", "Remars", tb_Remarks, "Remarks", "Remark_ID");
                    LoadDataList("RemarkInfoes", "Remars", "Remark_ID", "Remarks");
                }
            }
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
         
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
