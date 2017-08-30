using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaMaster areamaster1 = new AreaMaster(1,"India","IND","India is a country",AreaMaster.AreaType.Country,0);
            AreaMaster areamaster2 = new AreaMaster(2, "Maharashtra", "MH", "Maharashtra is a state in India", AreaMaster.AreaType.State, 1);
            AreaMaster areamaster3 = new AreaMaster(3, "Pune", "PUN", "Pune is a city in Maharashtra", AreaMaster.AreaType.City, 2);
            AreaMaster areamaster4 = new AreaMaster(4, "Pune District", "PD", "Anything", AreaMaster.AreaType.District, 3);

            AreaMaster am = new AreaMaster();
            Console.Write("Get information about areas: \n 1)Information  of Country \n 2)Information  of State \n 3)Information  of City \n 4)Information  of District \n Your choice:");
            int option = Int32.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    am.GetAreaMasterByCountry("India");
                    break;
                case 2:
                    am.GetAreaMasterByState("Maharashtra");
                    break;
                case 3:
                    am.GetAreaMasterByCity("Pune");
                    break;
                case 4:
                    am.GetAreaMasterByDistrict("Pune District");
                    break;
            }
            Console.ReadLine();
        }
    }
}
