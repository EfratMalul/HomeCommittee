using HomeCommittee.DAL;
using HomeCommittee.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommittee.BL.Converters
{
    public class BuildingConverter
    {
        public static building_tbl ToDAL(Building building)
        {
            return new building_tbl()
            {
                id = building.id,
                address = building.address,
                num = building.number,
                city = building.city,
                entrance = building.entrance,
                zip_code = building.zip_code,
                num_apartments = building.num_apartments
            };
        }

        public static Building ToDTO(building_tbl building)
        {
            return new Building()
            {
                id = building.id,
                address = building.address,
                number = building.num,
                city = building.city,
                entrance = building.entrance,
                zip_code = building.zip_code,
                num_apartments = building.num_apartments
            };
        }

        public static List<building_tbl> ListToDAL(List<Building> listBuilding)
        {
            return listBuilding.Select(b => ToDAL(b)).ToList();
        }

        public static List<Building>ListToDTO(List<building_tbl> listBuilding)
        {
            return listBuilding.Select(b => ToDTO(b)).ToList();
        }

    }
}
