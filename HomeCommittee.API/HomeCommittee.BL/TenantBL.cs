﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeCommittee.Entties;
using HomeCommittee.DAL;
using HomeCommittee.BL.Converters;

namespace HomeCommittee.BL
{
   public class TenantBL
    {

        public static void AddTenant(Tenant t)
        {
            TenantDAL.Add(TenantConverter.ToDAL(t));
        }

        public static List<Tenant> GetAll()
        {
            return TenantConverter.ListToDTO(TenantDAL.Get());
        }

        public static Tenant GetById(int id)
        {
          return  TenantConverter.ToDTO(TenantDAL.GetById(id));
        }
    }
}
