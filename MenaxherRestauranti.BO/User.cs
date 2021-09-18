using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO
{
    public class User : BaseObject
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime ExpiresDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public virtual List<Role> roles { get; set; }
    }
}
