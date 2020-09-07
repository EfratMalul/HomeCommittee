using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.Entties
{
    public class Survey
    {
        public int id { get; set; }
        public string issue { get; set; }
        public string option { get; set; }
        public Nullable<bool> is_open { get; set; }
        public Nullable<System.DateTime> open_date { get; set; }
        public Nullable<System.DateTime> close_date { get; set; }
        public Nullable<int> building_id { get; set; }
    }
}
