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
    public class OrderDAL : ICrudBase<Order>, IConvertToObject<Order>
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;

        public bool Add(Order model)
        {

            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Order_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "userID", model.userID);
                        command.Parameters.AddWithValue(parameterName: "productID", model.productID);
                        command.Parameters.AddWithValue(parameterName: "quantity", model.quantity);
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

        public List<Order> GetAll_User(int userID)
        {
            try
            {
                List<Order> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Order_GetUser"))
                    {
                        command.Parameters.AddWithValue(parameterName: "userID", userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Order>();
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

        public List<Order> GetAll()
        {

            try
            {
                List<Order> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_Order_GetAll"))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Order>();
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


        public Order ToObject(SqlDataReader reader)
        {
            Order order = new Order();
            order.orderID = int.Parse(reader["orderID"].ToString());
            order.userID = int.Parse(reader["userID"].ToString());
            order.productID = int.Parse(reader["productID"].ToString());
            order.quantity = int.Parse(reader["quantity"].ToString());
            order.InsertBy = reader["insertBy"].ToString();
            order.InsertDate = (DateTime)reader["insertDate"];
            order.LastUpdatedBy = reader["lastUpdatedBy"].ToString();
            order.LastUpdateDate = (DateTime)reader["lastUpdateDate"];
            order.UpdateNo = int.Parse(reader["updateNo"].ToString());
            return order;
        }

        public int Update(Order model)
        {
            throw new NotImplementedException();
        }

    }
}
