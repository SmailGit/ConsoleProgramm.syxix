using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramm.syxix
{
    internal class Program
    {
        public static City { get; private set; }

    public static void Main(string[] args, City )
        {
            Region p = new Region(500000, 20);
            Console.WriteLine(p.ToString());
        City City = new City(10000, 5, 15);
        Console.WriteLine(City.ToString());

            District District = new District(20000, 10, 10);
            Console.WriteLine(District.ToString());

            Village Village = new Village(30000, 5, 5);
            Console.WriteLine(Village.ToString());

            Console.ReadKey();
        }
    }
}