using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class SpyNo
    {
        static void Main(string[] args)
        {
            int sum = 0, product = 1,rev=0;
            Console.WriteLine("Enter the number to check whether it is spy number or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int number1 = num;
            while(num>0)
            {
                rev = num % 10;
                sum = sum + rev;
                product = product * rev;
                num = num / 10;
            }
            if(sum==product)
            {
                Console.WriteLine(number1 + " is Spy Number");
            }
            else
            {
                Console.WriteLine(number1 + " is Not Spy Number");
            }
            Console.ReadLine();
        }
    }
}
