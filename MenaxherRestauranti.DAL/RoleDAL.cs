using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using MenaxherRestauranti.BO;
using MenaxherRestauranti.BO.interfaces;

namespace MenaxherRestauranti.DAL
{
    public class RoleDAL : ICrudBase<Role>, IConvertToObject<Role>
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;

        public bool Add(Role model)
        {
            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Role_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "roleName", model.RoleName);
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
            catch (Exception)
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
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Role_RemovebyID"))
                    {
                        command.Parameters.AddWithValue(parameterName: "RoleID", ID);
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

        public List<Role> GetAll()
        {
            try
            {
                List<Role> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Roles_GetAll"))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Role>();
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

        public List<Role> GetAll_User(int id)
        {
            throw new NotImplementedException();
        }

        public Role ToObject(SqlDataReader reader)
        {
            Role role = new Role();
            role.RoleID = int.Parse(reader["roleID"].ToString());
            role.RoleName = reader["roleName"].ToString();
            role.InsertBy = reader["insertBy"].ToString();
            role.InsertDate = (DateTime)reader["insertDate"];
            role.LastUpdatedBy = reader["lastUpdatedBy"].ToString();
            role.LastUpdateDate = (DateTime)reader["lastUpdateDate"];
            role.UpdateNo = int.Parse(reader["updateNo"].ToString());
            return role;
        }

        public int Update(Role model)
        {
            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Role_UpdateByID"))
                    {
                        command.Parameters.AddWithValue(parameterName: "RoleName", model.RoleName);
                        int result = command.ExecuteNonQuery();
                        return result;


                    }
                }
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }
    }
}
