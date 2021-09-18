//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MenaxherRestauranti.DAL
//{
//    public class newdb
//    {
//        private string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;
//        public SqlConnection Sqlcon;
//        public newdb()
//        {
//            Sqlcon = new SqlConnection(this._connectionString);
//        }
//            public DataTable executeSqlCommand(string sqlCommand)
//            {
//                DataTable dtTable = new DataTable();
//                try
//                {
//                    //open sql connection
//                    this.Sqlcon.Open();
//                    //create sqlAdapter
//                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.Sqlcon);
//                    dataAdapter.Fill(dtTable);
//                    this.Sqlcon.Close();
//                }
//                catch (Exception error)
//                {
//                    Console.Write(error.ToString());
//                    dtTable = null;
//                }
//                return dtTable;
//            }
//    }
  
//}
