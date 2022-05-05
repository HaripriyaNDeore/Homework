using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    class QueEmployee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Empdesignation { get; set; }
        public int Salary { get; set; }
        static void Main(string[] args)
        {
            QueEmployee emp1 = new QueEmployee()
            {
                Empid = 101,
                Empname = "Pranali",
                Empdesignation = "Enginear",
                Salary = 20000
            };
            QueEmployee emp2 = new QueEmployee()
            {
                Empid = 102,
                Empname = "Vaibhav",
                Empdesignation = "Enginear",
                Salary = 25000
            };
            QueEmployee emp3 = new QueEmployee()
            {
                Empid = 103,
                Empname = "Ronit",
                Empdesignation = "Enginear",
                Salary = 24000
            };
            Queue<QueEmployee> dq = new Queue<QueEmployee>();
            dq.Enqueue(emp1);
            dq.Enqueue(emp2);
            dq.Enqueue(emp3);

            foreach (QueEmployee emp in dq)
            {
                Console.WriteLine(emp.Empid + "  " + emp.Empname + "  " + emp.Empdesignation + "  " + emp.Salary);
            }

            dq.Dequeue();
            Console.WriteLine("------------------------After Dequeue----------------------------");
            foreach (QueEmployee emp in dq)
            {
                Console.WriteLine(emp.Empid + "  " + emp.Empname + "  " + emp.Empdesignation + "  " + emp.Salary);
            }

        }
    }
}
