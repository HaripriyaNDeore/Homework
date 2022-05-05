using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Classwork.Collection
{
    class EmployeeCompare : IComparable
    {
       
        public int Eid { get; set; }
        public string Ename { get; set; }
       public int Salary { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
    public class test:IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            EmployeeCompare e1 = (EmployeeCompare)obj1;
            EmployeeCompare e2 = (EmployeeCompare)obj2;
            if (e1.Salary > e2.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            EmployeeCompare e = new EmployeeCompare { Eid = 1, Ename="Pooja",Salary = 20000 };
        }
    }
   
}
