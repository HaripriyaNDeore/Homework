using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class Tri1
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 7; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine();
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 7; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
