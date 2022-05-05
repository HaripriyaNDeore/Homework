using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    public class Emp
    {
        public String ename;
        public double Salary;
    }
    public class Test<t>
    {
        private t data;
        public void Add(t data)
        {
            this.data = data;
        }
        public t Get()
        {
            return data;
        }
    }
    class DictProduct
    {
        static void Main(string[] args)
        {
            Test<int> t1 = new Test<int>();
            t1.Add(10);
            Console.WriteLine(t1.Get());

            Test<String> t2 = new Test<String>();
            t2.Add("Priya");
            Console.WriteLine(t1.Get());

            Test<Emp> t3 = new Test<Emp>();
            t3.Add(new Emp { ename = "Rahul", Salary = 25000 });

            Emp e = t3.Get();
            Console.WriteLine(e.ename+" "+e.Salary);
        }
    }
}
