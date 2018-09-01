using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            House h = new House();

            House clone = h.Clone() as House;

            h.show();
            Console.WriteLine();
            Console.WriteLine("Clone");
            clone.show();
            clone.floors = 3;
            clone.type = "cotegge";
            Console.WriteLine();
            Console.WriteLine("Changed clone");
            clone.show();

            Console.ReadLine();
        }
    }
}
