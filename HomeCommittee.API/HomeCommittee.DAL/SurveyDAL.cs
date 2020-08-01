using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.DAL
{
    public static class SurveyDAL
    {
        //get all
        //get by id
        //add
        //update
        //delete
        public static List<survey_tbl> Get()
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.survey_tbl.ToList();
            }
        }

        public static survey_tbl GetById(int id)
        {
            using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
            {
                return db.survey_tbl.Find(id);
            }
        }

        public static void Add(survey_tbl survey)
        {
            try
            {
                using (HomeCommitteeDBEntities db = new HomeCommitteeDBEntities())
                {
                    db.survey_tbl.Add(survey);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
