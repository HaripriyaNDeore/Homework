using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class Maxno
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st numbers");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3st numbers");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("1st Number is Maximum");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("2nd Number is Maximum");
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine("3rd Number is Maximum");
            }
            else
            {
                Console.WriteLine("Invalid ");
            }
            Console.Read();


        }
    }
}
