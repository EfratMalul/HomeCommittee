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
   public  class PaymentBL
    {
        public static void AddPayment(Payment payment)
        {
            PaymentDAL.Add(PaymentConverter.ToDAL(payment));
        }

        public static List<Payment> GetAll()
        {
            return PaymentConverter.ListToDTO(PaymentDAL.Get());
        }

        public static Payment GetById(int id)
        {
            return PaymentConverter.ToDTO(PaymentDAL.GetById(id));
        }

    }
}
