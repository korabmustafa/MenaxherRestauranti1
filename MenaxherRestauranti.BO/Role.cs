using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO
{
    public class Role : BaseObject
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public virtual List<User> users { get; set; }
    }
}
