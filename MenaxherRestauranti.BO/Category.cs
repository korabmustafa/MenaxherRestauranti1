using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO
{
    public class Category:BaseObject
    {
        public int categoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual Product Product { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
