using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainGeneratorConsole.Generators
{
    /// <summary>
    /// Gets a random value from collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class RandomGenerator<T>
    {
        static ICollection<T> valuesSet = new List<T>();

        /// <summary>
        /// Gets a random value from passed in set of values.
        /// </summary>
        /// <param name="values">Set of values to get random from.</param>
        /// <returns>T</returns>
        public static T GetRandom(IEnumerable<T> values)
        {
            valuesSet = values as ICollection<T>;

            try
            {
                Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
                var nxt = r.Next(valuesSet.Count);

                return valuesSet.ElementAt(nxt);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to get random value.", e);
            }
        }
    }
}
