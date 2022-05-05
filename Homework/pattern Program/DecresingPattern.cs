using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class DecresingPattern
    {
        static void Main(string[] args)
        {

            /*12345
            2345
            345
            45
            5*/
            for (int r=1;r<=5;r++)
            {
                for(int c=r;c<=5;c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine();

            /*11111
            2222
            333
            44
            5*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            /*54321
            5432
            543
            54
            5*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 5; c >= r; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();


            Console.Read();
        }
    }
}
