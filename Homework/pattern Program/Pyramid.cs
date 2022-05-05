using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Rows");
            int r1 = Convert.ToInt32(Console.ReadLine());
            for (int r = 1; r <= 5; r++)
            {
                for (int space = 1; space < r1 - r; space++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            for (int r = 4; r >= 1; r--)
            {
                for (int space = 1; space < r1 - r; space++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
