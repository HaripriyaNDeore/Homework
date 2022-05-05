using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class pattern1
    {
        static void Main(string[] args)
        {
            int i=1,j = 1;
            for(j=1;j<=i;j=j+1)
            {
                for(i=1;i<=5;i=i+1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
