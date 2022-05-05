using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class LeftTriangle
    {
        static void Main(string[] args)
        {
            /*
                     1
                    12
                   123
                  1234
                  12345*/


            for (int i=1;i<=5;i++)
            {
                for (int space = 1; space <= 5 - i; space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        
            /*
                    6
                   56
                  456
                 3456
                23456
               123456
            */
            for (int i = 6; i >= 1; i--)
            {
                for (int space = 1; space <= i - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 6; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            /*
             
            *******
             *****
              ***
               *



             */
            Console.WriteLine("Enter Number Of Rows");
            int r = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r; i = i + 2)
            {
                for (int space = 1; space < r - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= r; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
              *
             ***
            *****
           *******
          *********
         ***********
        *************
       ***************
      *****************
             */

            Console.WriteLine("Enter Number Of Rows");
            int r1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r1; i++)
            {
                for (int space = 1; space < r1 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            /*
            1
            AB
            123
            ABCD
            12345



             */


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(i%2==1)
                    Console.Write(j);
                    else
                    Console.Write((char)(64+j));
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
