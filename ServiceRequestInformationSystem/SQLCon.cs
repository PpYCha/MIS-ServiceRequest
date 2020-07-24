using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    static class SQLCon
    {
        public static DataSet dataSet = new DataSet();
        public static SqlCommand sqlCommand;
        public static SqlDataReader sqlDataReader;
        public static SqlDataAdapter sqlDataApater = new SqlDataAdapter();
        public static SqlConnection sqlConnection = new SqlConnection();
        public static DataTable dataTable = new DataTable();
        public static string sql;

      //static string dataSource = "PPYCHA"; 
      //  static string databaseName = "TestSrisDb";
      static string dataSource = "tcp:PPYCHA,49172";
        static string databaseName = "SrisDb";
        //mycon = new SqlConnection(@"Data Source = tcp:desktop-neljd6c,1433; Initial Catalog = PAO-Information-System; Persist Security Info=True; User ID=emmaPC; Password='corona_2020'");
        public static void DbCon()

        {
            try
            {
                sqlConnection.Close();
             // sqlConnection = new SqlConnection("Data Source='" + dataSource + "'; Initial Catalog='" + databaseName + "'; Integrated Security=true");
               sqlConnection = new SqlConnection("Data Source='" + dataSource + "'; Initial Catalog='" + databaseName + "'; Persist Security Info=True; User ID=miso_server; Password='miso4321'");
                sqlConnection.Open();


            }
            catch (Exception)
            {
                MessageBox.Show("System can not stablish a connection to database!");
            }
        }
    }
}