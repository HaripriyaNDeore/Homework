using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Haripriya
    {
        public void m1()
        {
            Console.WriteLine("I am in M1");
        }
        public void m2()
        {
            Console.WriteLine("I am in M2");
        }
        public static void m3()
        {
            Console.WriteLine("I am in M3");
        }
        public static void m4()
        {
            Console.WriteLine("I am in M4");
        }
        static void Main(string[] args)
        {
            Haripriya h = new Haripriya();
            h.m1();
            h.m2();
            Haripriya.m3();
            Haripriya.m4();
            Console.Read();
        }
    }
}

