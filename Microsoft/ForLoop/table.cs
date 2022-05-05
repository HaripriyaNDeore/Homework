using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class table
    {
        static void Main(string[] args)
        {
            int n = 13;
            for(int i=1;i<=50;i++)
            {
                Console.WriteLine($"{n}x{i}={n*i}");
            }
            Console.Read();
        }
    }
}
