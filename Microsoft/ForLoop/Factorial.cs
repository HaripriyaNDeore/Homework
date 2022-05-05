using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1,num;
            Console.WriteLine("Enter the number to check the factorial of number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of  "+num+" is "+fact);

        }
    }
}
