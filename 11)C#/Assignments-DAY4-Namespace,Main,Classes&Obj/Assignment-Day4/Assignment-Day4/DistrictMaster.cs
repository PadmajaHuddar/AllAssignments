using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    class DistrictMaster : AreaMaster
    {
        public override AreaType GetAreaType
        {
            get
            {
                return AreaType.District;
            }

            set
            {
                GetAreaType = AreaType.District;
            }
        }
    }
}
