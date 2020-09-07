using HomeCommittee.DAL;
using HomeCommittee.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.BL.Converters
{
    public static class SurveyConverter
    {
        public static survey_tbl ToDAL(Survey s)
        {
            return new survey_tbl
            {
                id = s.id,
                issue = s.issue,
                is_open = s.is_open,
                open_date = s.open_date,
                close_date = s.close_date,
                building_id = s.building_id
            };
        }
        public static Survey ToDTO(survey_tbl s)
        {
            return new Survey
            {
                id = s.id,
                issue = s.issue,
                is_open = s.is_open,
                open_date = s.open_date,
                close_date = s.close_date,
                building_id = s.building_id
            };
        }
        public static List<survey_tbl> ListToDAL(List<Survey> list)
        {
            return list.Select(s => ToDAL(s)).ToList();
        }

        public static List<Survey> ListToDTO(List<survey_tbl> list)
        {
            return list.Select(s => ToDTO(s)).ToList();
        }
    }
}
