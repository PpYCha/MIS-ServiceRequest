using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace ServiceRequestInformationSystem
{
    public partial class ucImportExcel : UserControl
    {
        public ucImportExcel()
        {
            InitializeComponent();
        }

        private static ucImportExcel _instance;
        public static ucImportExcel Instance 
        { get
            {
                if (_instance == null)
                    _instance = new ucImportExcel();
                return _instance;
            }
             }

        private void bt_ImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Browse Excel";
            opd.DefaultExt = "xlsx";
            opd.Filter = "PDF files (*.xlsx |*.xlsx;)";
            opd.Multiselect = false;


            if (opd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fi = new FileInfo(opd.FileName);
                    ImportTOS(fi);
                    ImportOffices(fi);
                    ImportRemarks(fi);

                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage excelPackage = new ExcelPackage(fi))
                    {
                        ExcelWorksheet firstWorkSheet = excelPackage.Workbook.Worksheets[0];

                        ExcelWorksheet namedWorksheet = excelPackage.Workbook.Worksheets["Sheet1"];


                        string[] rowValue = new string[7];
                        var start = firstWorkSheet.Dimension.Start;
                        var end = firstWorkSheet.Dimension.End;


                        //rowValue[0] = "1";  //Type of Service
                        //rowValue[1] = "Rosalie D. Poblete";
                        //rowValue[2] = "1" ;// Od_Id
                        //rowValue[3] = "9/23/2018";

                        //rowValue[4] = "9/23/2018";
                        //rowValue[5] = "1"; //RemarksId
                        //rowValue[6] = "Ariel O. Cardeño";
                        int rowStart = Convert.ToInt32(tb_Start.Text);
                        int rowEnd = Convert.ToInt32(tb_End.Text);


                        for (int row = rowStart; row <= rowEnd; row++)
                        {
                            int i = 0;

                            for (int col = 2; col <= 8; col++)
                            {
                                object cellValue = firstWorkSheet.Cells[row, col].Text;
                                //string cellValue = firstWorkSheet.Cells["B1"].Value.ToString();
                                //rowValue += (string)cellValue + ",");

                                rowValue[i] = cellValue.ToString();


                                i++;
                            }

                            SQLCon.DbCon();
                            SQLCon.sqlCommand = new SqlCommand("" +
                             @"
                             
                              SELECT TS_ID, TypeOfServiceProvided FROM TypeOfServices WHERE TypeOfServiceProvided = @1
                            ", SQLCon.sqlConnection);
                            SQLCon.sqlCommand.Parameters.AddWithValue("@1", rowValue[0]);
                            SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();

                            string tS_ID = "";

                            while (SQLCon.sqlDataReader.Read())
                            {

                                tS_ID = (SQLCon.sqlDataReader["TS_ID"].ToString());
                            }

                            SQLCon.DbCon();
                            SQLCon.sqlCommand = new SqlCommand("" +
                                @"
                              SELECT OD_ID, OfficeDepartmentName FROM OfficeDepartments WHERE OfficeDepartmentName = @2 ;
                        
                            ", SQLCon.sqlConnection);

                            SQLCon.sqlCommand.Parameters.AddWithValue("@2", rowValue[3]);
                            string od_ID = "";
                            SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();
                            while (SQLCon.sqlDataReader.Read())
                            {
                                od_ID = (SQLCon.sqlDataReader["OD_ID"].ToString());

                            }

                            SQLCon.DbCon();
                            SQLCon.sqlCommand = new SqlCommand("" +
                             @"
                             
                              SELECT Remark_ID, Remars FROM RemarkInfoes WHERE Remars = @3
                            ", SQLCon.sqlConnection);
                            SQLCon.sqlCommand.Parameters.AddWithValue("@3", rowValue[6]);
                            SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();
                            string Remark_ID = "";

                            while (SQLCon.sqlDataReader.Read())
                            {

                                Remark_ID = (SQLCon.sqlDataReader["Remark_ID"].ToString());
                            }



                            SQLCon.DbCon();
                            SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO ServiceRequestInfoes 
                                VALUES(
                                    @TS_ID,
                                    @RequestedBy,   
                                    @OD_ID,
                                    @DateRequested,
                                    @5,
                                    @DateAccomplished,
                                    @Remark_ID,
                                    @Status,
                                    @ServiceProvidedBy)", SQLCon.sqlConnection);
                            SQLCon.sqlCommand.CommandType = CommandType.Text;

                            if (!(string.IsNullOrEmpty(rowValue[0]) || string.IsNullOrEmpty(rowValue[1]) || string.IsNullOrEmpty(rowValue[2]) || string.IsNullOrEmpty(rowValue[3]) || string.IsNullOrEmpty(rowValue[4]) || string.IsNullOrEmpty(rowValue[5]) || string.IsNullOrEmpty(rowValue[6])))
                            {
                                try
                                {
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@TS_ID", Convert.ToInt32(tS_ID));
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@RequestedBy", rowValue[1]);
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@OD_ID", Convert.ToInt32(od_ID));
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateRequested", Convert.ToDateTime(rowValue[2]));
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@5", DBNull.Value); //Time Left Column
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@DateAccomplished", Convert.ToDateTime(rowValue[4]));
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@Remark_ID", Convert.ToInt32(Remark_ID)); //rowValue[5]
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@Status", 1);
                                    SQLCon.sqlCommand.Parameters.AddWithValue("@ServiceProvidedBy", rowValue[5]);

                                    SQLCon.sqlCommand.ExecuteNonQuery();
                                }
                                catch (Exception)
                                {


                                }

                            }


                            //}

                        }


                    }
                }
                catch (Exception)
                {


                }
                MessageBox.Show("Successfully Imported");
            }
        }

        private void ImportRemarks(FileInfo filename)
        {


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(filename))
            {
                ExcelWorksheet firstWorkSheet = excelPackage.Workbook.Worksheets[0];

                ExcelWorksheet namedWorksheet = excelPackage.Workbook.Worksheets["Sheet1"];

                string rowValue = "";
                var start = firstWorkSheet.Dimension.Start;
                var end = firstWorkSheet.Dimension.End;
             

                int rowStart = Convert.ToInt32(tb_Start.Text);
                int rowEnd = Convert.ToInt32(tb_End.Text);
                for (int row = rowStart; row <= rowEnd; row++)
                {

                    for (int col = 8; col <= 8; col++)
                    {
                        object cellValue = firstWorkSheet.Cells[row, col].Text;

                        rowValue = cellValue.ToString();

                    }

                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("SELECT Remars FROM RemarkInfoes WHERE Remars = @1", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", rowValue);
                    SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();
                    string checkIfExist = "";
                    while (SQLCon.sqlDataReader.Read())
                    {
                        checkIfExist = (SQLCon.sqlDataReader["Remars"].ToString());
                    }

                    if (rowValue != checkIfExist && rowValue != "")
                    {
                        SQLCon.DbCon();
                        SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO RemarkInfoes 
                                VALUES(
                                    @Remars,
                                    @IsActive)", SQLCon.sqlConnection);
                        SQLCon.sqlCommand.CommandType = CommandType.Text;

                        SQLCon.sqlCommand.Parameters.AddWithValue("@Remars", rowValue);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@IsActive", 1);

                        SQLCon.sqlCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        private void ImportOffices(FileInfo fileInfo)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet firstWorkSheet = excelPackage.Workbook.Worksheets[0];

                ExcelWorksheet namedWorksheet = excelPackage.Workbook.Worksheets["Sheet1"];


                string rowValue = "";
                var start = firstWorkSheet.Dimension.Start;
                var end = firstWorkSheet.Dimension.End;
              

                //rowValue[0] = "1";
                //rowValue[1] = "Rosalie D. Poblete";
                //rowValue[2] = "1" ;// Od_Id
                //rowValue[3] = "9/23/2018";

                //rowValue[4] = "9/23/2018";
                //rowValue[5] = "1"; //RemarksId
                //rowValue[6] = "Ariel O. Cardeño";
                int rowStart = Convert.ToInt32(tb_Start.Text);
                int rowEnd = Convert.ToInt32(tb_End.Text);
                for (int row = rowStart; row <= rowEnd; row++)
                {

                    for (int col = 5; col <= 5; col++)
                    {
                        object cellValue = firstWorkSheet.Cells[row, col].Text;
                        //string cellValue = firstWorkSheet.Cells["B1"].Value.ToString();
                        //rowValue += (string)cellValue + ",");

                        rowValue = cellValue.ToString();


                    }

                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("SELECT OfficeDepartmentName FROM OfficeDepartments WHERE OfficeDepartmentName = @1", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", rowValue);
                    SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();
                    string checkIfExist = "";
                    while (SQLCon.sqlDataReader.Read())
                    {
                        checkIfExist = (SQLCon.sqlDataReader["OfficeDepartmentName"].ToString());
                    }

                    if (rowValue != checkIfExist && rowValue != "")
                    {
                        SQLCon.DbCon();
                        SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO OfficeDepartments 
                                VALUES(
                                    @OfficeDepartmentName,
                                    @IsActive)", SQLCon.sqlConnection);
                        SQLCon.sqlCommand.CommandType = CommandType.Text;

                        SQLCon.sqlCommand.Parameters.AddWithValue("@OfficeDepartmentName", rowValue);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@IsActive", 1);

                        SQLCon.sqlCommand.ExecuteNonQuery();
                    }



                }
            }
        }

        private void ImportTOS(FileInfo filename)
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(filename))
            {
                ExcelWorksheet firstWorkSheet = excelPackage.Workbook.Worksheets[0];

                ExcelWorksheet namedWorksheet = excelPackage.Workbook.Worksheets["Sheet1"];


                string rowValue = "";
                var start = firstWorkSheet.Dimension.Start;
                var end = firstWorkSheet.Dimension.End;

                //rowValue[0] = "1";
                //rowValue[1] = "Rosalie D. Poblete";
                //rowValue[2] = "1" ;// Od_Id
                //rowValue[3] = "9/23/2018";

                //rowValue[4] = "9/23/2018";
                //rowValue[5] = "1"; //RemarksId
                //rowValue[6] = "Ariel O. Cardeño";
                int rowStart = Convert.ToInt32(tb_Start.Text);
                int rowEnd = Convert.ToInt32(tb_End.Text);
                for (int row = rowStart; row <= rowEnd; row++)
                {

                    for (int col = 2; col <= 2; col++)
                    {
                        object cellValue = firstWorkSheet.Cells[row, col].Text;
                        //string cellValue = firstWorkSheet.Cells["B1"].Value.ToString();
                        //rowValue += (string)cellValue + ",");

                        rowValue = cellValue.ToString();


                    }

                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("SELECT TypeOfServiceProvided FROM TypeOfServices WHERE TypeOfServiceProvided = @1", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", rowValue);
                    SQLCon.sqlDataReader = SQLCon.sqlCommand.ExecuteReader();
                    string checkIfExist = "";
                    while (SQLCon.sqlDataReader.Read())
                    {
                        checkIfExist = (SQLCon.sqlDataReader["TypeOfServiceProvided"].ToString());
                    }

                    if (rowValue != checkIfExist && rowValue != "")
                    {
                        SQLCon.DbCon();
                        SQLCon.sqlCommand = new SqlCommand(@"INSERT INTO TypeOfServices 
                                VALUES(
                                    @TypeofService,
                                    @IsActive)", SQLCon.sqlConnection);
                        SQLCon.sqlCommand.CommandType = CommandType.Text;

                        SQLCon.sqlCommand.Parameters.AddWithValue("@TypeofService", rowValue);
                        SQLCon.sqlCommand.Parameters.AddWithValue("@IsActive", 1);

                        SQLCon.sqlCommand.ExecuteNonQuery();
                    }



                }
            }

        }
    }
}
