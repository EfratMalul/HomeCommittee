using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.Entties
{
   public class Payment
    {
        public int id { get; set; }
        public int ? building_id { get; set; }
        public double ? sum { get; set; }
        public DateTime ? date_payment { get; set; }

    }
}
