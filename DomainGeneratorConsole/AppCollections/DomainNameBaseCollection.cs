using DomainGeneratorConsole.AppInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainGeneratorConsole.AppCollections
{
    internal abstract class DomainNameBaseCollection : List<string>, IPopulate
    {
        public abstract void Populate();
    }
}
