using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class O
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <=6; r++)
            {
                Console.Write("o");

                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || r == 6 || c==5)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
