using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class ThreeDigit
	{
        static void Main(string[] args)
        {
            int Num, sum = 0;
            Console.WriteLine("Enter the number");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num > 99 || Num < 1000)
            {
                Console.WriteLine("Number is Three Digit");
                sum = sum + Num % 10;
                Num = Num / 10;
                Console.WriteLine("sum of 1st and 3rd digit is  " + sum);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.Read();
        }
    }
}
