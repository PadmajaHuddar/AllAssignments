using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    class AreaMaster
    {
        public AreaMaster() { }
        public AreaMaster(int Id, string Name, string Code, string Description, AreaType GetAreaType, int AreaId)
        {
            this.Id = Id;
            this.Code = Code;
            this.Name = Name;
            this.Description = Description;
            this.GetAreaType = GetAreaType;
            this.AreaId = AreaId;
            AreaCollection.Add(this);
        }
        public enum AreaType
        {
            Country, State, City, District
        }
        private int Id{get; set;}
        private string Code{get; set;}
        private string Name{ get; set; }
        private string Description { get; set; }
        public virtual AreaType GetAreaType { get; set; }
        private int AreaId { get; set; }
        static List<AreaMaster> AreaCollection = new List<AreaMaster>();
        public int city_id;
        public int country_id;
        public int state_id;

        public void GetAreaMasterByDistrict(string name)
        {
            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.District && area.Name == name)
                {
                    Console.WriteLine("District: {0}", name);
                    city_id = area.AreaId;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.City && area.Id == city_id)
                {
                    Console.WriteLine("City: {0}", area.Name);
                    state_id = area.AreaId;
                }
            }
           
            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.State && area.Id == state_id)
                {
                    Console.WriteLine("State: {0}", area.Name);
                    country_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.Country && area.Id == country_id)
                {
                    Console.WriteLine("Country: {0}", area.Name);
                    //_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.District && area.Name == name)
                {
                    Console.WriteLine("Code: {0}", area.Code);
                    Console.WriteLine("Description: {0}", area.Description);
                    Console.Read();
                }
            }

        }

        public void GetAreaMasterByCity(string name)
        {
            foreach(var area in AreaCollection)
            {
                if(area.GetAreaType==AreaType.City && area.Name==name)
                {
                    Console.WriteLine("City: {0}",name);
                    state_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.State && area.Id == state_id)
                {
                    Console.WriteLine("State: {0}", area.Name);
                    country_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.Country && area.Id == country_id)
                {
                    Console.WriteLine("Country: {0}", area.Name);
                    //_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.City && area.Name == name)
                {
                    Console.WriteLine("Code: {0}",area.Code);
                    Console.WriteLine("Description: {0}",area.Description);
                    Console.Read();
                }
            }
            
        }
        public void GetAreaMasterByState(string name)
        {
            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.State && area.Name == name)
                {
                    Console.WriteLine("State: {0}", name);
                    country_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.Country && area.Id == country_id)
                {
                    Console.WriteLine("Country: {0}", area.Name);
                    //_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.State && area.Name == name)
                {
                    Console.WriteLine("Code: {0}", area.Code);
                    Console.WriteLine("Description: {0}", area.Description);
                    Console.Read();
                }
            }
        }
        public void GetAreaMasterByCountry(string name)
        {
            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.Country && area.Name == name)
                {
                    Console.WriteLine("Country: {0}", name);
                    //_id = area.AreaId;
                }
            }

            foreach (var area in AreaCollection)
            {
                if (area.GetAreaType == AreaType.Country && area.Name == name)
                {
                    Console.WriteLine("Code: {0}", area.Code);
                    Console.WriteLine("Description: {0}", area.Description);
                    Console.Read();
                }
            }
        }
    }
}
