using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Recur
{
    class FactRev
    {
        public static int fact(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int result = fact(n - 1);
                return n * result;
            }
               
        }
        static void Main(string[] args)
        {
            FactRev.fact(5);
            Console.ReadLine();
        }
    }
}
