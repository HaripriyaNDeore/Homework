using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SimpleProgram
{
    class Calculator
    {
        public void Add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition Is "+sum);
        }
        public float SimpleInterest(int p, float r,int y)
        {
            float interest = p * r * y;
            return interest;
        }
        public bool IsLeafYear(int y)
        {
            if(y%4==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Add(1,3);
            float SimpleInterest=cal.SimpleInterest(2, 4, 5);
           Console.WriteLine("SimpleInterest is "+ SimpleInterest);
            bool IsLeafYear=cal.IsLeafYear(2020);
            Console.WriteLine(IsLeafYear);
            Console.Read();

        }
    }
}
