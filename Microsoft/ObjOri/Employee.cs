using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Employee
    {
        private int id;
        private string name;
        private int salary;
        public Employee()
        {
            Console.WriteLine("In Employee Constructor");
        }
        public void SetEmpId(int empid)
        {
            id = empid;
        }
        public int GetEmpId()
        {
            return id;
        }
        public void SetEmpName(string  nm)
        {
            name = nm;
        }
        public string GetEmpName()
        {
            return name;
        }
        public void SetEmpSalary(int empsal)
        {
            salary = empsal;
        }
        public int GetEmpSalary()
        {
            return salary;
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetEmpId(1);
            emp.SetEmpName("Priya");
            emp.SetEmpSalary(20000);

            int eid = emp.GetEmpId();
            string name1 = emp.GetEmpName();
            float sal1 = emp.GetEmpSalary();

            Console.WriteLine("Employee Id: " + eid + "Employee Name: " + name1 + "Employee Salary: " + sal1);
            Console.ReadLine();
        }


    }
}
