using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    class StacEmployee
    {
        
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Empdesignation { get ; set ; }
        public int Salary { get ; set; }



        static void Main(string[] args)
        {
            StacEmployee emp1 = new StacEmployee()
            {
                Empid = 101,
                Empname = "Pranali",
                Empdesignation = "Enginear",
                Salary = 20000
            };
            StacEmployee emp2 = new StacEmployee()
            {
                Empid = 102,
                Empname = "Vaibhav",
                Empdesignation = "Enginear",
                Salary = 25000
            };
            StacEmployee emp3 = new StacEmployee()
            {
                Empid = 103,
                Empname = "Ronit",
                Empdesignation = "Enginear",
                Salary = 24000
            };

            Stack<StacEmployee> stackEmployees = new Stack<StacEmployee>();
            stackEmployees.Push(emp1);
            stackEmployees.Push(emp2);
            stackEmployees.Push(emp3);
            Console.WriteLine(" Id" + "  " + " Name" + "  " + " Designation" + "  " + " Salary");
            foreach (StacEmployee emp in stackEmployees)
            {
                Console.WriteLine(emp.Empid + "  " + emp.Empname + "  " + emp.Empdesignation + "  " + emp.Salary);
            }
            stackEmployees.Pop();
            Console.WriteLine("------------------------After pop----------------------------");
            foreach (StacEmployee emp in stackEmployees)
            {
                Console.WriteLine(emp.Empid + "  " + emp.Empname + "  " + emp.Empdesignation + "  " + emp.Salary);
            }
        }
    }
}
