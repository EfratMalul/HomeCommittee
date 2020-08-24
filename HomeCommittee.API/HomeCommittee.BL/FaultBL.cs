using HomeCommittee.BL.Converters;
using HomeCommittee.DAL;
using HomeCommittee.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.BL
{
   public class FaultBL
    {
        public static void AddFault(Fault fault)
        {
            FaultDAL.Add(FaultConverter.ToDAL(fault));
        }
        public static List<Fault> GetAll()
        {
            return FaultConverter.ListToDTO(FaultDAL.Get());
        }
        public static Fault GetById(int id)
        {
            return FaultConverter.ToDTO(FaultDAL.GetById(id));
        }

    }
}
