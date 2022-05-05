using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class KrishnamurtiNo
    {
        static void Main(string[] args)
        {
            int number, sum, digit, fact;
            Console.WriteLine("Enter the number to check whether it is Krishnamurthy  or not");
            number = Convert.ToInt32(Console.ReadLine());
            int no1 = number;
            sum = 0;
            while (no1 != 0)
            {
                digit = no1 % 10;
                fact = 1;

               
                for (int i = 1; i <= digit; i++)
                {
                    fact=fact * i;
                }

                sum =sum + fact;
                no1 = no1 / 10;
            }
            if (sum == number)
            {
                Console.WriteLine("Number is Krishnamurthy");
            }
            else
            {
                Console.WriteLine("Number is not Krishnamurthy");
            }
            Console.Read();
               

        }
    }
}
