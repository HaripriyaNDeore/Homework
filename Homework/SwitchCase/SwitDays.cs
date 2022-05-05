using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
    class SwitDays
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the number");
            day = Convert.ToInt32(Console.ReadLine());


            switch (day)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("error, day does not exist");
                    break;

            }
            Console.Read();
        }


    }
}
