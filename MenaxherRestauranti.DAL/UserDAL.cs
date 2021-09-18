using MenaxherRestauranti.BO;
using MenaxherRestauranti.BO.interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.DAL
{
    public class UserDAL : ICrudBase<User>, IConvertToObject<User>
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;
        public bool Add(User model)
        {

            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_User_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "username", model.Username);
                        command.Parameters.AddWithValue(parameterName: "password", model.Password);
                        command.Parameters.AddWithValue(parameterName: "firstname", model.Firstname);
                        command.Parameters.AddWithValue(parameterName: "lastname", model.Lastname);
                        command.Parameters.AddWithValue(parameterName: "roleID", model.RoleID);
                        command.Parameters.AddWithValue(parameterName: "ExpiresDate", model.ExpiresDate);
                        command.Parameters.AddWithValue(parameterName: "insertBy", model.InsertBy);
                        command.Parameters.AddWithValue(parameterName: "lastUpdatedBy", model.LastUpdatedBy);
                        command.Parameters.AddWithValue(parameterName: "updateNo", model.UpdateNo);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                    }
                    }
            catch (Exception ex )
            {
                return false;
                //throw;
            }
        }

        public int Delete(int ID)
        {
            try
            {   
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_User_RemovebyID", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "userID", ID);
                        int result = command.ExecuteNonQuery();
                        return result;

                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
                throw;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                List<User> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Users_GetAll"))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<User>();
                            while (reader.Read())
                            {
                                result.Add(ToObject(reader));

                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public User ToObject(SqlDataReader reader)
        {
            User user = new User();
            user.UserID = int.Parse(reader["userID"].ToString());
            user.RoleID = int.Parse(reader["roleID"].ToString());
            user.Username = reader["username"].ToString();
            user.Password = reader["password"].ToString();
            user.Firstname = reader["firstname"].ToString();
            user.Lastname = reader["lastname"].ToString();
            user.InsertBy = reader["insertBy"].ToString();
            user.InsertDate = (DateTime)reader["insertDate"];
            user.ExpiresDate = (DateTime)reader["ExpiresDate"];
            user.LastLoginDate = (DateTime)reader["LastLoginDate"];
            user.LastUpdatedBy = reader["lastUpdatedBy"].ToString();
            user.LastUpdateDate = (DateTime)reader["lastUpdateDate"];
            user.UpdateNo = int.Parse(reader["updateNo"].ToString());

            return user;
        }
        public User Login(string username,string password)
        {
            try
            {
                User user = null;
                using (var conn = mydatabase.Sqlconn())
                {
                    using (var cmd = mydatabase.Command(conn, cmdText: "dbo.usp_Authenticate", CommandType.StoredProcedure))
                    {
                        cmd.Parameters.AddWithValue(parameterName: "username",username);
                        cmd.Parameters.AddWithValue(parameterName: "password", password);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = ToObject(reader);
                            }
                        }
                    }
                }
                return user;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }          
        }
        public int Update(User model)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll_User(int id)
        {
            throw new NotImplementedException();
        }
    }
}
