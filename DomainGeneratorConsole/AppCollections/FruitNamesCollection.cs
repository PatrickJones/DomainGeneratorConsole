using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainGeneratorConsole.AppCollections
{
    internal class FruitNamesCollection : DomainNameBaseCollection
    {
        public FruitNamesCollection()
        {
            Populate();
        }

        public override void Populate()
        {
            if (this.Count == 0)
            {
                this.AddRange(new List<string> {
                    "Açaí",
                    "Apple",
                    "Akee",
                    "Apricot",
                    "Avocado",
                    "Banana",
                    "Bilberry",
                    "Blackberry",
                    "Blackcurrant",
                    "Blueberry",
                    "Boysenberry",
                    "Currant",
                    "Cherry",
                    "Chico fruit",
                    "Coconut",
                    "Cranberry",
                    "Cucumber",
                    "Damson",
                    "Date",
                    "Dragonfruit"
                });
            }
        }
    }
}
