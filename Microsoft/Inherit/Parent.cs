using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("In Default Constructor");
        }
        public void m1()
        {
            Console.WriteLine(" In m1 method");
        }
        public void m2()
        {
            Console.WriteLine("In m2 method");
        }
    }
    class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("In child Constructor");
        }
        public void m3()
        {
            Console.WriteLine("In child m3 method");
        }
        public void m4()
        {
            Console.WriteLine("In child m4 method");
        }
    }
    class child1
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.m1();
            c.m2();
            Console.ReadLine();
        }
    }
}
