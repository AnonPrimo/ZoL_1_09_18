using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Data
    {
        private int Day { set; get; }
        private int Mon { set; get; }
        private int Year { set; get; }

        public Data()
        {
            Day = DateTime.Today.Day;
            Mon = DateTime.Today.Month;
            Year = DateTime.Today.Year;
        }


        public void show()
        {
            Console.WriteLine("Day: {0} \nMonth: {1} \nYear: {2}", Day, Mon, Year);
        }

        public static int operator +(Data d1, int n)
        {

            if(d1.Day + n <= 30)





            return 3;
        }
    }
}
