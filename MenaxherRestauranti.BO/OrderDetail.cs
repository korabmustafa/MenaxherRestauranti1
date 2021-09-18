using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO
{
    public class OrderDetail : BaseObject
    {
        public int orderDetailsID { get; set; }
        public int orderID { get; set; }
        public decimal orderSubtotal { get; set; }
        public decimal orderTotal { get; set; }
        public decimal orderTax { get; set; }
        public decimal orderChange { get; set; }
        public decimal orderCharge { get; set; }

        public virtual Order Order { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
