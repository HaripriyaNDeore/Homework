using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class StatMethod
    {
        public static int i;
        public static void display()
        {
            int i = 10;
            Console.WriteLine(i);
        }
        public void demo()
        {
            int j = 20;
            Console.WriteLine(j);
        }
        static void Main(string[] args)
        {
            StatMethod sm = new StatMethod();
            StatMethod.display();
            sm.demo();
            Console.Read();
        }
    }
}
