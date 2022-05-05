using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class PrinWor
	{
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter the number");
            Num = Convert.ToInt32(Console.ReadLine());


            switch (Num)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    Console.WriteLine("FOUR");
                    break;
                case 5:
                    Console.WriteLine("FIVE");
                    break;
                default:
                    Console.WriteLine("error, day does not exist");
                    break;

            }
            Console.Read();
        }
    }
}
