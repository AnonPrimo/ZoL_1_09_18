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

            Console.WriteLine();

            House deepclone = (House)h.DeepClone();
            Console.WriteLine("Deep clone");
            deepclone.show();

            deepclone.floors = 5;
            deepclone.type = "build";
            Console.WriteLine();

            Console.WriteLine("Changed deep clone");
            deepclone.show();


            Console.ReadLine();
        }
    }
}
