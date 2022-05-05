using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class trleap
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());
            string leap = year % 4 == 0 ? "leap" : "not leap";
            Console.WriteLine("leap");
            Console.Read();
        }
    }
}
