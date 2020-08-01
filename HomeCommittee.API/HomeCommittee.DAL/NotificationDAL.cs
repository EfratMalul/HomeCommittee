using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.DAL
{
   public static class NotificationDAL
    {
        //get all
        //get by id
        //add
        //update
        //delete
        public static List<notification_tbl> Get()
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.notification_tbl.ToList();
            }
        }

        public static notification_tbl GetById(int id)
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.notification_tbl.Find(id);
            }
        }

        public static void Add(notification_tbl notification)
        {
            try
            {
                using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
                {
                    db.notification_tbl.Add(notification);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
