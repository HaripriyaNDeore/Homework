using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class CalculationChain
    {
        public CalculationChain(int a)
        {

            Console.WriteLine("Addition is "+a);
        }
        public CalculationChain(int a,int b):this(a)
        {
            Console.WriteLine("Addition Of Two Variable is "+(a+b));
        }
        public CalculationChain (int a,int b,int c):this(a,b)
        {
            Console.WriteLine("Addition Of Three Variable is " + (a+b+c));
        }
        static void Main(string[] args)
        {
            CalculationChain c = new CalculationChain(1, 2, 3);
            Console.ReadLine();

        }
    }
   
}
