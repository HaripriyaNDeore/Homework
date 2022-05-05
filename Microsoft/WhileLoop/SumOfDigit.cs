using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check whether it is Harshad Niven Or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine("Sum Of Digit is "+sum);
            Console.Read();
        }
    }
}
