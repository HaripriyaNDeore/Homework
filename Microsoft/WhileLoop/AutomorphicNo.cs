using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class AutomorphicNo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int no = Convert.ToInt32(Console.ReadLine());
            int sqr = no * no;
            int flag = 0;
            while (no > 0)
            {
                if (no % 10 != sqr % 10)
                {
                    flag = -1;
                    break;
                }
                no = no / 10;
                sqr = sqr / 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
            Console.ReadLine();
        }
    }
}
