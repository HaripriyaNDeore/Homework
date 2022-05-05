using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class ParentC
    {
        private protected int x=10;
        protected internal int y=20;
        public virtual void m1()
        {
            Console.WriteLine("In parent class m1");
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public virtual void m2()
        {
            Console.WriteLine("In parent class m2");
        }

    }
    class ChildC:ParentC
    {
       
        public override void m1()
        {
            Console.WriteLine("In child class m1");
        }
        public override void m2()
        {
            Console.WriteLine("In child class m2");
        }
        public override string ToString()
        {

            return "Hi";
        }
    }
    sealed class SubChild:ChildC
    {
        public void m1()
        {
            Console.WriteLine("In subchid class m1");
        }
        public void m2()
        {
            Console.WriteLine("In subchid class m2");
        }
       
    }
    class check
    {
        static void Main(string[] args)
        {
            
            ParentC pc = new ChildC();
            pc.m1();
            pc.m2();

            ChildC cc = new ChildC();
            cc.m1();
            cc.m2();

            SubChild sc = new SubChild();
            sc.m1();
            sc.m2();
           Console.WriteLine(pc.y);
          
            Console.ReadLine();
        }
    }
}
