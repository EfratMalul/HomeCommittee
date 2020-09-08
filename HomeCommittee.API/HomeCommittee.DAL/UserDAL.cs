using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.DAL
{
    public static class UserDAL
    {
        //get all
        //get by id
        //add
        //update
        //delete

        public static List<user_tbl> Get()
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.user_tbl.ToList();
            }
        }

        public static user_tbl GetById(int id)
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.user_tbl.Find(id);
            }
        }

        public static void Add(user_tbl user)
        {
            try
            {
                using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
                {
                    db.user_tbl.Add(user);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static user_tbl GetByPassword(string user_name,string password)
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.user_tbl.FirstOrDefault(u => u.password == password && u.user_name == user_name);

            }
        }

    }
}
