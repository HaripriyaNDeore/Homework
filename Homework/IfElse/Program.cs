using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to check whether a number is divisible by 5 and 11 or not ");
            int num = Convert.ToInt32(Console.ReadLine());

            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Number is divisible by 5 & 11");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 & 11");
            }
            Console.Read();

        }
    }
}
