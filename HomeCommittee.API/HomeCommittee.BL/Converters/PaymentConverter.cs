using HomeCommittee.DAL;
using HomeCommittee.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.BL.Converters
{
   public class PaymentConverter
    {
          public static Payment ToDTO(payment_tbl payment)
        {
            return new Payment()
            {
                id = payment.id,
                building_id = payment.building_id,
                sum = payment.sum,
                date_payment = payment.date_payment
            };
        }

        public static payment_tbl ToDAL(Payment payment)
        {
            return new payment_tbl()
            {
                id = payment.id,
                building_id = payment.building_id,
                sum = payment.sum,
                date_payment = payment.date_payment
            };
        }

        public static List<Payment> ListToDTO (List<payment_tbl> list)
        {
            return list.Select(p => ToDTO(p)).ToList();
        }

        public static List<payment_tbl>ListToDAL(List<Payment> list)
        {
            return list.Select(p => ToDAL(p)).ToList();
        }
    }
}
