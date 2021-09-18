using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO.interfaces
{
   public interface ICrudBase<T>
    {
        bool Add(T model);
        int Update(T model);
        int Delete(int ID);
        List<T> GetAll();
        List<T> GetAll_User(int id);
    }
}
