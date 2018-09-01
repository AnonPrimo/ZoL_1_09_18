using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b1 = new Block(1, 1, 1, 1);
            Block b2 = new Block(2, 2, 2, 2);
            Block b3 = new Block(1, 1, 1, 1);

            Console.WriteLine("b1 == b2: " + b1.Equals(b2));
            Console.WriteLine("b1 == b3: " + b1.Equals(b3));
            Console.WriteLine("b2 == b3: " + b2.Equals(b3));
            Console.WriteLine();

            Console.WriteLine("B1\n" + b1.ToString());
            Console.WriteLine("B2\n" + b2.ToString());
            Console.WriteLine("B3\n" + b3.ToString());


            Console.ReadLine();
        }
    }
}
