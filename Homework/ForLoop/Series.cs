using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print series till the number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("square of number and add 1 Series is....");
            //2,5,10,17,26,377.....
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine((i * i + 1) + " ");
            }
            Console.WriteLine("square of number Series is....");
            for (int i = 1; i <= n; i++)
            {
                // square of number and printing series
                Console.WriteLine(i * i + " ");
            }
            Console.WriteLine("square of number and subtract by 1.. Series is....");
            for (int i = 1; i <= n; i++)
            {
                // square of number and subtract by 1 and printing series
                Console.WriteLine(i * i - 1+ " ");
            }
            Console.Read();
        }
    }
}
