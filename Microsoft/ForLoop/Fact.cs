using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop

{
    class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.Read());
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                    Console.WriteLine(i);
            }
        }
    }
}
