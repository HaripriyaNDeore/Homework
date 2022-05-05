using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class T
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 6; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (r == 1 && (c == 1 || c == 2 || c == 3 || c == 4 || c == 5||c==6))
                    {
                        Console.Write("T");
                    }
                    else if (c == 3 &&( r == 1 || r == 2 || r == 3 || r == 4 || r == 5 ||r==6 ))
                    {
                        Console.Write("T");
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
