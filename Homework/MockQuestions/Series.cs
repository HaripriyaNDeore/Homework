using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check next number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                int n1 = a + b;
                a = b;
                b = n1;

            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
