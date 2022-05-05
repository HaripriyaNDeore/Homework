using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class Hap
    {
        static void Main(string[] args)
        {
            int rem = 0,sum=0;
            Console.WriteLine("Enter the number to check whether it is happy or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int evencou = 0, oddcou = 0;
            while (num > 0)
            {
                 rem = num % 10;
                if (rem % 2 == 0)
                    evencou++;
                else
                    oddcou++;
                num = num / 10;
            }
            if (evencou == 1)
            {
                Console.WriteLine("Number is Unhappy");
            }
            else
            {
                Console.WriteLine("Number is Happy");
            }

        }
    }
}
