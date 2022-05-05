using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class HarshadNiven
    {
        static void Main(string[] args)
        {
            int sum = 0,r;
            Console.WriteLine("Enter the number to check whether it is Harshad Niven Or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            int No = num;
            while (num > 0)
            {//1234
                r = num % 10;//4//123%10==3//12%10=2//1%10=1
                sum = sum + r;//0+4=4//4+3=7//7+2=9//9+1=10
                num = num / 10;//1234/10==123//123/10=12//12/10=1
            }
            if (No == sum)//1234==10
            {
                Console.WriteLine("It is a Harshad Niven Number");
            }
            else
            {
                Console.WriteLine("It is  Not aHarshad Niven Number");
            }
            Console.Read();

           
        }
    }
}
