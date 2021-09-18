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
    public class OrderDetailsDAL : ICrudBase<OrderDetail>, IConvertToObject<OrderDetail>
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;
        public bool Add(OrderDetail model)
        {

            throw new NotImplementedException();

        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetAll()
        {

            try
            {
                List<OrderDetail> result = null;
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_OrderDetails_GetAll"))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<OrderDetail>();
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

        public OrderDetail ToObject(SqlDataReader reader)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.orderDetailsID = int.Parse(reader["orderDetailsID"].ToString());
            orderDetail.orderID = int.Parse(reader["orderID"].ToString());
            orderDetail.orderSubtotal= decimal.Parse(reader["orderSubtotal"].ToString());
            orderDetail.orderTotal = decimal.Parse(reader["orderTotal"].ToString());
            orderDetail.orderTax = decimal.Parse(reader["orderTax"].ToString());
            orderDetail.orderChange = decimal.Parse(reader["orderChange"].ToString());
            orderDetail.orderCharge = decimal.Parse(reader["orderCharge"].ToString());
            orderDetail.InsertBy = reader["insertBy"].ToString();
            orderDetail.InsertDate = (DateTime)reader["insertDate"];
            orderDetail.LastUpdatedBy = reader["lastUpdatedBy"].ToString();
            orderDetail.LastUpdateDate = (DateTime)reader["lastUpdateDate"];
            orderDetail.UpdateNo = int.Parse(reader["updateNo"].ToString());

            return orderDetail;
        }

        public int Update(OrderDetail model)
        {
            throw new NotImplementedException();
        }
        public int GetOrderDetails(int ID)
        {
            try
            {
                using (var connection = mydatabase.Sqlconn())
                {
                    using (var command = mydatabase.Command(connection, cmdText: "dbo.usp_OrderDetails_Get", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue(parameterName: "productID", ID);
                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
                //throw;
            }
        }

        public List<OrderDetail> GetAll_User(int id)
        {
            throw new NotImplementedException();
        }
    }
}
