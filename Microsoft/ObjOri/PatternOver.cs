using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class PatternOver
    {
        public void pattern(int i)
        {
            for (i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void pattern(int r,int c,char ch)
        {
            for (r = 1; r <= 5; r++)
            {
                for (int j = 5; j >= c; j--)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            PatternOver po = new PatternOver();
            po.pattern(2);
            po.pattern(5,3,'@');
            Console.ReadLine();
        }

    }
}
