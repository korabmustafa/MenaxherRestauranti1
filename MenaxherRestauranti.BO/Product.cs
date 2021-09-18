using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO
{
    public class Product : BaseObject
    {
        public int productID { get; set; }
        public int categoryID { get; set; }
        public int userID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public decimal productPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
