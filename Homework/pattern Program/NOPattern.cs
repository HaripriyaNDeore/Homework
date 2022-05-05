using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class NOPattern
    {
        static void Main(string[] args)
        {
             /* 5
                54
                543
                5432
                54321*/

            for(int i=5; i >= 1; i--)
            {
                for(int j=5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

          /*5
            45
            345
            2345
            12345*/

            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

             /*  1
                13
                135
                1357
                13579*/

            for (int i = 1; i <= 9; i=i+2)
            {
                for (int j = 1; j <= i; j =j+ 2)
                { 
                        Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

             /* *
                **
                ***
                ****
                ******/
            for(int r=1;r<=5;r++)
            {
                for(int c=1;c<=r;c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

              /*54321
                5432
                543
                54
                5*/

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

             /* 1
                22
                333
                4444
                55555*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

              /*1
                12
                123
                1234
                12345*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

             /*EDCBA
                DCBA
                CBA
                BA
                A*/

            for (char r = 'E'; r >= 'A'; r--)
            {
                for (char c = r; c >= 'A'; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            /*A
                AB
                ABC
                ABCD
                ABCDE*/
            for (char r = 'A'; r <= 'E'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            /*A
            BB
            CCC
            DDDD
            EEEEE*/

            for (char r = 'A'; r <= 'E'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            /*12345
                2345
                345
                45
                5*/
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
