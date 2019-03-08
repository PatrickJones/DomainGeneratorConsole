using DomainGeneratorConsole.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainGeneratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new DomainGenerator(1);
            gen.GenerateDomains();

            foreach (var item in gen.DomainCards)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Total generated: {gen.DomainCards.Count}");
            Console.ReadLine();
        }
    }
}
