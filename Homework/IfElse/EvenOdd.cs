using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class EvenOdd
	{
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter the Number to Check Whether it is ODD or EVEN");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine(Num + " Number is EVEN");
            }
            else
            {
                Console.WriteLine(Num + " Number is ODD");
            }
            Console.ReadLine();
        }
    }
}
