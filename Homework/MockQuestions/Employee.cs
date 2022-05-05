using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Employee
    {
        int empid;
        string empname;
        int empsalary;

        public Employee()
        {

        }

        public Employee(int empid, string empname, int empsalary)
        {
            this.Empid = empid;
            this.Empname = empname;
            this.Empsalary = empsalary;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Empname { get => empname; set => empname = value; }
        public int Empsalary { get => empsalary; set => empsalary = value; }
    }
    class Employee1
    {
        static void Main(string[] args)
        {
           
            Employee[] newEmp = new Employee[2];
            newEmp[0] = new Employee { Empid=1, Empname = "riya", Empsalary = 2000 };
            newEmp[1] = new Employee { Empid =2, Empname = "piya", Empsalary = 40000 };
            /*for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter the Employee Id ");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee name ");
                empname = Console.ReadLine();
                Console.WriteLine("Enter the Employee salary ");
                empsalary = Convert.ToInt32(Console.ReadLine());

            }*/
           /* for(int i=0;i<=2;i++)
            {
                if(newEmp > 40000)
                {

                }
            }*/
            Console.WriteLine("Employee Details");
            Console.WriteLine("the Employee Id " + newEmp);

        }
    }
        
    
}
