using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    class CityMaster: AreaMaster
    {
        public override AreaType GetAreaType
        {
            get
            {
                return AreaType.City;
            }

            set
            {
                GetAreaType = AreaType.City;
            }
        }
    }
}
