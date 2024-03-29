﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeCommittee.DAL
{
   public class ExpenditureDAL
    {
        public static expenditure_tbl GetById(int id)
        {
            using(HomeCommitteeDBEntities db=new HomeCommitteeDBEntities())
            {
               return db.expenditure_tbl.Find(id);
            }
        }

        public static List<expenditure_tbl> Get()
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.expenditure_tbl.ToList();
            }

        }

        public static void Add(expenditure_tbl expenditure)
        {
            try
            {
                using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
                {
                    db.expenditure_tbl.Add(expenditure);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
