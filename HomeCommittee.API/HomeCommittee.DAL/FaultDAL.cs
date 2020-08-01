﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.DAL
{
   public class FaultDAL
    {
        public static fault_tbl GetById(int id)
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.fault_tbl.Find(id);
            }
        }

        public static List<fault_tbl> Get()
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.fault_tbl.ToList();
            }
        }

        public static void Add(fault_tbl fault)
        {
            try
            {
                using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
                {
                    db.fault_tbl.Add(fault);
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