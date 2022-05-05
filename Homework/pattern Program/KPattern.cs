using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class KPattern
    {
        static void Main(string[] args)
        {
            int row = 15;
            int end = row;
            for (int r= 1;r<= row;r++)
            {
                for (int c = 1; c <= row; c++)
                {
                    if (c == 1 || c == end)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }  
                Console.WriteLine();
                if(r<=row/2)
                {
                    end = end - 2;
                }
                else
                {
                    end = end + 2;
                }
               
            }
            for (int r = 1; r <=7; r++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    Console.Write("S");
                }
            }
                    Console.Read();
        }
    }
}
