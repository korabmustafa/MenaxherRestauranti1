using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO.interfaces
{
    public interface IConvertToObject<T> where T:class
    {
        T ToObject(SqlDataReader reader);

    }
}
