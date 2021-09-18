using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.BO
{
   public class BaseObject
    {
        public string InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int UpdateNo { get; set; }
    }
}
