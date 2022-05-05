using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class AmicableNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int SumNum1 = 0, SumNum2 = 0;
            for(int i=1;i<=num1;i++)
            {
                if(num1 % i == 0)
                {
                    SumNum1 = SumNum1 + i;
                }
            }
            for (int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0)
                {
                    SumNum2 = SumNum2 + i;
                }
            }
            if(SumNum1==SumNum2)
            {
                Console.WriteLine("No is Amicable");
            }
            else
            {
                Console.WriteLine("No is Not Amicable");
            }
            Console.Read();
        }
    }
}
