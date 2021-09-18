using MenaxherRestauranti.BO;
using MenaxherRestauranti.BO.interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.DAL
{
   public class ProductDAL : ICrudBase<Product>, IConvertToObject<Product>
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;
        public bool Add(Product model)
        {
            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Product_Insert",CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "productName", model.productName);
                        command.Parameters.AddWithValue(parameterName: "productDescription", model.productDescription);
                        command.Parameters.AddWithValue(parameterName: "productPrice", model.productPrice);
                        command.Parameters.AddWithValue(parameterName: "categoryID", model.categoryID);
                        command.Parameters.AddWithValue(parameterName: "userID", model.userID);
                        command.Parameters.AddWithValue(parameterName: "insertBy", model.InsertBy);
                        //command.Parameters.AddWithValue(parameterName: "insertDate", model.InsertDate);
                        command.Parameters.AddWithValue(parameterName: "lastUpdatedBy", model.LastUpdatedBy);
                        //command.Parameters.AddWithValue(parameterName: "lastUpdateDate", model.LastUpdateDate);
                        command.Parameters.AddWithValue(parameterName: "updateNo", model.UpdateNo); 
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
                //throw;
            }
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll()
        {
            try
            {
                List<Product> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Products_GetAll"))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Product>();
                            while (reader.Read())
                            {
                                var products = ToObject(reader);
                                if (reader["categoryName"] != DBNull.Value)
                                {
                                    products.Category = new Category { CategoryName = reader["categoryName"].ToString() };
                                }
                                result.Add(products);
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAll_User(int userID)
        {
            try
            {
                List<Product> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Products_GetUser"))
                    {
                        mydatabase.AddParameter(command, "userID", userID);
                        //command.Parameters.AddWithValue(parameterName: "userID", userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Product>();
                            while (reader.Read())
                            {
                                var products = ToObject(reader);
                                if (reader["categoryName"] != DBNull.Value)
                                {
                                    products.Category = new Category { CategoryName = reader["categoryName"].ToString() };
                                }
                                result.Add(products);
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                string ee = ex.Message;
                throw;
            }
        }

        public Product ToObject(SqlDataReader reader)
        {
            Product product = new Product();
            product.productID = int.Parse(reader["productID"].ToString());
            product.categoryID = int.Parse(reader["categoryID"].ToString());
            product.userID = int.Parse(reader["userID"].ToString());
            product.productName = reader["productName"].ToString();
            product.productDescription = reader["productDescription"].ToString();
            product.productPrice = decimal.Parse(reader["productPrice"].ToString());
            product.InsertBy = reader["insertBy"].ToString();
            product.InsertDate = (DateTime)reader["insertDate"];
            product.LastUpdatedBy = reader["lastUpdatedBy"].ToString();
            product.LastUpdateDate = (DateTime)reader["lastUpdateDate"];
            product.UpdateNo = int.Parse(reader["updateNo"].ToString());
            return product;
        }

        public int Update(Product model)
        {
            throw new NotImplementedException();
        }
        public bool GetProduct(Product model)
        {
            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Product_Get", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "productName", model.productID);
                        int result = command.ExecuteNonQuery();
                        return result>0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
                //throw;
            }
        }
    }
}
