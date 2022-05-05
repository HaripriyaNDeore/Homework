using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class HarshadNo
    {
        static void Main(string[] args)
        {
            int sum = 0,rem;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num/10;
            }
            if (num1 == sum)
            {
                Console.WriteLine("Number is Harshad Number");
            }
            else
            {
                Console.WriteLine("Number is Not Harshad");
            }
            Console.Read();


        }
    }
}
