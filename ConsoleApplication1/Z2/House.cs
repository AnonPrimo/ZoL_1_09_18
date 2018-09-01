using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class House
    {
        public int floors;
        public string type;

        public House()
        {
            floors = 2;
            type = "Villa";
        }

        public House(int f, string t)
        {
            floors = f;
            type = t;
        }

        public House Clone()
        {
            return new House(this.floors, this.type);
        }

        public object DeepClone()
        {
            return new House(this.floors, this.type) as object;
        }

        public void show()
        {
            Console.WriteLine("floors: " + floors);
            Console.WriteLine("type: " + type);
        }
    }
}
