using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainGeneratorConsole.AppCollections
{
    internal class CityNamesCollection : DomainNameBaseCollection
    {
        public CityNamesCollection()
        {
            Populate();
        }

        public override void Populate()
        {
            if (this.Count == 0)
            {
                this.AddRange(new List<string> {
                "NewYork",
                "LosAngeles",
                "Chicago",
                "Houston",
                "Phoenix",
                "Philadelphia",
                "SanAntonio",
                "SanDiego",
                "Dallas",
                "SanJose",
                "Austin",
                "Jacksonville",
                "SanFrancisco",
                "Columbus",
                "FortWorth",
                "Indianapolis",
                "Charlotte",
                "Seattle",
                "Denver",
                "Washington"
                }); 
            }
        }
    }
}
