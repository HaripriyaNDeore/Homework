using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Recur
{
    class ReverseNo
    {

        static void printreverse(int n)
        {
           
            if(n>0)
            {

                for (int i = n; i > 0; i--)
                    Console.Write(i);

            }
        }
        static void Main(string[] args)
        {
            ReverseNo.printreverse(5);
            Console.ReadLine();
        }
    }
}
