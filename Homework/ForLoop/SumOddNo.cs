using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class SumOddNo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("first 10 odd Number is");
            for(int i=1;i<=10; i=i+2)
            {
                Console.WriteLine(i);
                sum = sum + i;

            }
            Console.WriteLine("Sum of first 10 odd Number is "+ sum);
            Console.Read();
        }
    }
}
