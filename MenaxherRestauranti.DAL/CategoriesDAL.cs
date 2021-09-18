using MenaxherRestauranti.BO;
using MenaxherRestauranti.BO.interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MenaxherRestauranti.DAL
{
    public class CategoriesDAL : ICrudBase<Category>, IConvertToObject<Category>
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;
        public bool Add(Category model)
        {
            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Categories_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "categoryName", model.CategoryName);
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

        public List<Category> GetAll()
        {
            try
            {
                List<Category> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Categories_GetAll"))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Category>();
                            while (reader.Read())
                            {
                                result.Add(ToObject(reader));

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

        public List<Category> GetAll_User(int id)
        {
            throw new NotImplementedException();
        }

        public Category ToObject(SqlDataReader reader)
        {
            Category category = new Category();
            category.categoryID = int.Parse(reader["CategoryID"].ToString());
            category.CategoryName= reader["CategoryName"].ToString();
            category.InsertBy = reader["insertBy"].ToString();
            category.InsertDate = (DateTime)reader["insertDate"];
            category.LastUpdatedBy = reader["lastUpdatedBy"].ToString();
            category.LastUpdateDate = (DateTime)reader["lastUpdateDate"];
            category.UpdateNo = int.Parse(reader["updateNo"].ToString());
            return category;
        }

        public int Update(Category model)
        {
            throw new NotImplementedException();
        }
    }
}
