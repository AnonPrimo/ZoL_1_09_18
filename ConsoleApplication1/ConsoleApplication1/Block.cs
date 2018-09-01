using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Block
    {
        private int a;
        private int b;
        private int c;
        private int d;

        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public bool Equals(Block obj)
        {
            if (obj.a == this.a && obj.b == this.b && obj.c == this.c && obj.d == this.d)
                return true;
            return false;
        }

        public string ToString()
        {
            return "side a:" + a + "\nside b:" + b  + "\nside c:" + c + "\nside d:" + d + "\n";
        }

    }
}
