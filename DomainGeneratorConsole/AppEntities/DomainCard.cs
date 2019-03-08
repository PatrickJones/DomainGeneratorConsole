using DomainGeneratorConsole.AppEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainGeneratorConsole.AppEnums.EnumDefinitions;

namespace DomainGeneratorConsole.AppEntities
{
    /// <summary>
    /// Domain name card object.
    /// </summary>
    public class DomainCard
    {
        public DateTime DateGenerated => DateTime.Now;
        public string ActualDomainName { get; set; }
        public TopLevelDomainName TopLevelDomainName { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DomainCard()
        {}

        /// <summary>
        /// COnstructor that takes a actual domain name and top level domain name
        /// </summary>
        /// <param name="actualName">Actual domain name</param>
        /// <param name="tld">Top Level domain name</param>
        public DomainCard(string actualName, TopLevelDomainName tld)
        {
            ActualDomainName = actualName;
            TopLevelDomainName = tld;
        }

        public override string ToString()
        {
            return $"{ActualDomainName}.{TopLevelDomainName.ToString()}";
        }
    }
}
