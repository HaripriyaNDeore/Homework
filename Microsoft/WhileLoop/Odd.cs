using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class Odd
    {
        static void Main(string[] args)
        {
            // 521 to 229 odd number using while
            
            while (521 > 1)
            {
                for (int i = 521; i >=229; i=i-1)
                {
                    if (i % 2 != 0)
                        Console.Write(i+",");
                }
            }
            Console.ReadLine();
        }
    }
}
