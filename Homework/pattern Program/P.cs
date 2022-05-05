using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class P
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=5;i++)
            {
                Console.Write("#");
               
                    for (int j = 1; j <= 4; j++)
                    {
                        if (i == 1 || i == 3 || (i == 2 && j == 4))
                        {
                            Console.Write("#");
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
