using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.Entties
{
   public class Building
    {
        public int id { get; set; }
       
        public string building { get; set; }
        public string address { get; set; }
        public int  number { get; set; }
        public string city { get; set; }
        public int  entrance { get; set; }//כניסה
        public int   zip_code { get; set; }
        public int  num_apartments { get; set; }
    }
}
