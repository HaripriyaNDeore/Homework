using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class E
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("E");
               for (int j = 1; j <= 4; j++)
               {
                    if (i == 1 || i == 4 || i==7)
                    {
                        Console.Write("E");
                    }
                    else
                    {
                        Console.Write("");
                    }
               }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.WriteLine();




            Console.Read();
        }
    }
}
