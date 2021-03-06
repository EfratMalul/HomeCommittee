﻿using HomeCommittee.BL.Converters;
using HomeCommittee.DAL;
using HomeCommittee.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.BL
{
    public class ExpenditureBL
    {
        public static List<Expenditure> Get()
        {
            return ExpenditureConverter.ListToDTO(ExpenditureDAL.Get());
        }

        public static Expenditure GetById(int id)
        {
            return ExpenditureConverter.ToDTO(ExpenditureDAL.GetById(id));
        }

        public static void Add(Expenditure expenditure)
        {
             ExpenditureDAL.Add(ExpenditureConverter.ToDAL(expenditure));
        }
    }
}
