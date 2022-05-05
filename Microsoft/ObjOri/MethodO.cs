using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class MethodO
    {
        public void addition(int a)
        {
            Console.WriteLine("number is "+a);
        }
        public void addition(int a,int b)
        {
            Console.WriteLine("Additon of two number is "+(a+b));
        }
    }
    class Method1
    {
        static void Main(string[] args)
        {
            MethodO oo = new MethodO();
            oo.addition(1);
            oo.addition(2, 5);
            Console.ReadLine();
        }
       
    }
}
