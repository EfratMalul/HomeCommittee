using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.DAL
{
    public class PaymentDAL
    {

        public static List<payment_tbl> Get()
        {
           using(HomeCommitteeDBEntities db =new HomeCommitteeDBEntities())
            {
                return db.payment_tbl.ToList();
            }
        }

        public static payment_tbl GetById(int id)
        {
            using(HomeCommitteeDBEntities db=new HomeCommitteeDBEntities())
            {
               return db.payment_tbl.Find(id);
            }
        }

        public static void Add(payment_tbl payment)
        {
            try
            {
                using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
                {
                    db.payment_tbl.Add(payment);
                    db.SaveChanges();
                }
            }

            catch
            {
                throw;
            }
        }
    }
}
