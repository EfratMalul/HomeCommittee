using HomeCommittee.DAL;
using HomeCommittee.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.BL
{
    public class SurveyBL
    {
        public static void AddSurvey(Survey survey)
        {
            SurveyDAL.Add(Converters.SurveyConverter.ToDAL(survey));
        }

        public static List<Survey> GetAll()
        {
            return Converters.SurveyConverter.ListToDTO(SurveyDAL.Get());
        }
        public static Survey GetById(int id)
        {
            return Converters.SurveyConverter.ToDTO(SurveyDAL.GetById(id));
        }
    }
}
