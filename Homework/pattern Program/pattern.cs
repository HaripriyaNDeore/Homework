using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class pattern
    {
        static void Main(string[] args)
        {
            int i,j;


           /******
            ****
            ***
            **
            **
            */
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (i=5;i>=1;i--)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(  );





            for(int r=1;r<=5;r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if(c==1||r==1||r==3||(r<=3 && c==5))
                        Console.Write("*");
                    else
                        Console.Write("");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

          }
    }
}
