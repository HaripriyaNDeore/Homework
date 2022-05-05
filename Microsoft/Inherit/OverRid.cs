using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Parent1
    {
        public virtual void study()
        {
            Console.WriteLine("By reading book");
        }
       
    }
    class child:Parent1
    {
        public override void study()
        {
            Console.WriteLine("By watching  videos");
        }
    }
    class childd
    {
        static void Main(string[] args)
        {
            Parent1 pp = new Parent1();
            pp.study();
            Parent1 pp1 = new child();
            pp1.study();
            Console.ReadLine();
        }
        

    }
}
