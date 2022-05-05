using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
    class Bouncynumber
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=5;i++)
            {
                char k = 'A';
                for(int j=1;j<=i;j++)
                {
                    if(i%2!=0)
                    {
                        Console.WriteLine(j);
                    }
                    else
                    {
                        Console.WriteLine(k);
                        k++;
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
