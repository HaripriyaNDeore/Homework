using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class TwinPrime
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the 1st number to check whether it is twin prime or not");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num1 / 2 && i<=num2/2 ; i++)
            {
                if (num1 % i == 0 && num2 % i==0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0 && (num1 - num2 == 2 || num2 - num1 == 2))
            {
                Console.WriteLine("Number is twin prime");
            }
            else
            {
                Console.WriteLine("Number is not twin prime");
            }
            
           
            Console.Read();

        }
    }
}
