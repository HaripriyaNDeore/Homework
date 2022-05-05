using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class LeapYear
	{
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year to check whether it is Leap or not");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(year + "  It is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " It is not a leap year");
            }
            Console.Read();
        }
    }
}
