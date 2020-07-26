using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeCommittee.DAL;
using HomeCommittee.Entties;
using HomeCommittee.BL.Converters;

namespace HomeCommittee.BL
{
    public class UserBL
    {
        public static void AddUser(User user)
        {
            UserDAL.Add(UserConverter.ToDAL(user));
        }

        public static List<User> GetAll()
        {
            return UserConverter.ListToDTO(UserDAL.Get());
        }

        public static User GetById(int id)
        {
            return UserConverter.ToDTO(UserDAL.GetById(id));
        }
    }
}
