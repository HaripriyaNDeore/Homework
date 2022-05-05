using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Delegatess
{

    public delegate int MyDelegate(int n1, int n2);

    public class Calculation
    {
        public int Add(int no1,int no2)
        {
            Console.Write("Addition is=");
            return no1 + no2;
        }
        public int Sub(int no1, int no2)
        {
            Console.Write("Subtraction is= ");
            return no1 - no2;
        }
        public int Multiply(int no1, int no2)
        {
            Console.Write("Multiplication is= ");
            return no1 * no2;
        }
        public int Division(int no1, int no2)
        {
            Console.Write("Division is= ");
            return no1 / no2;
        }
    }
    class CalculationMulti
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            MyDelegate del = new MyDelegate(c.Add);
            del += new MyDelegate(c.Sub);
            del += new MyDelegate(c.Multiply);
            del += new MyDelegate(c.Division);

            Delegate[] list = del.GetInvocationList();
        

            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(12,2));
            }

        }
    }
}
