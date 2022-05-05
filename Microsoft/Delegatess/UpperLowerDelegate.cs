using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Delegatess
{
    public delegate void MyDelegate1(string s);

    class UpperLower
    {
        public void Upper(string nm)
        {
           Console.WriteLine("In Upper Case string is "+nm.ToUpper());
        }
        public void Lower(string nm)
        {
            Console.WriteLine("In Lower Case string is " + nm.ToLower());
        }

    }
    class UpperLowerDelegate
    {
        static void Main(string[] args)
        {
            UpperLower ul = new UpperLower();
            MyDelegate1 del = new MyDelegate1(ul.Upper);
            del += new MyDelegate1(ul.Lower);
            Delegate[] list =del.GetInvocationList();

            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("hello");
            }


        }

    }
}
