using DomainGeneratorConsole.AppCollections;
using DomainGeneratorConsole.AppEntities;
using DomainGeneratorConsole.AppEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DomainGeneratorConsole.AppEnums.EnumDefinitions;

namespace DomainGeneratorConsole.Generators
{
    /// <summary>
    /// Generates Random Domain names
    /// </summary>
    public class DomainGenerator
    {
        public List<DomainCard> DomainCards = new List<DomainCard>();

        private readonly CityNamesCollection Cities = new CityNamesCollection();
        private readonly FruitNamesCollection Fruits = new FruitNamesCollection();

        private int CountToGenerate = 1;

        /// <summary>
        /// Default constructor
        /// </summary>
        public DomainGenerator()
        {}

        /// <summary>
        /// Constructor that takes number of doamins to generate (max 20).
        /// </summary>
        /// <param name="generateCount">Number of domains to generate</param>
        public DomainGenerator(int generateCount)
        {
            CountToGenerate = (generateCount > 20) ? 20 : generateCount;
        }

        /// <summary>
        /// Domain generator
        /// </summary>
        /// <returns>IEnumerable<string> of domain names</returns>
        public IEnumerable<string> GenerateDomains()
        {
            try
            {
                if (Cities.Count == 0 || Fruits.Count == 0)
                {
                    throw new IndexOutOfRangeException("Cites or Fruits collecion is empty");
                }

                int current = 0;
                while (current < CountToGenerate)
                {
                    string fruit = RandomGenerator<string>.GetRandom(Fruits);
                    string city = RandomGenerator<string>.GetRandom(Cities);
                    TopLevelDomainName tld = RandomGenerator<TopLevelDomainName>.GetRandom(Enum.GetValues(typeof(TopLevelDomainName)).Cast<TopLevelDomainName>());

                    var dc = new DomainCard($"{fruit}-{city}", tld);

                    if (!DomainCards.Any(a => a.ToString() == dc.ToString()))
                    {
                        DomainCards.Add(dc);
                        current++;
                    }

                    Thread.Sleep(20);
                }

                return DomainCards.Select(s => s.ToString());
            }
            catch (Exception e)
            {
                throw new Exception("Unable to generate domain name(s).", e);
            }
        }
    }
}
