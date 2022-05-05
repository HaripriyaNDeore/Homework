using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    public class Employee
    {
        public int eid { get; set; }
        public String ename { get; set; }
    }
    public class Department
    {
        public int did { get; set; }
        public String dname { get; set; }
        public List<Employee> Employees = new List<Employee>();

    }
    class program
    {

   
    static void Main(string[] args)
    {
        List<Department> Departments = new List<Department>()
        {
            new Department{did=1,dname="Computer",Employees={new Employee{eid=1,ename="vaibhav"},
                                                            new Employee{eid=2,ename="Krush"},
                                                            new Employee{eid=3,ename="Ankita"}
                                                             }
            },
            new Department{did=2,dname="Civil",Employees={new Employee{eid=1,ename="Nishant"},
                                                            new Employee{eid=2,ename="priya"},
                                                            new Employee{eid=3,ename="Ankita"}
                                                             }
            }

        };
         
        foreach(Department d in Departments)
        {
            Console.WriteLine(d.did+" "+d.dname);
            foreach(Employee e in d.Employees)
            {
                Console.WriteLine($"{e.eid}{e.ename}");
            }
        }
        
    }
    }
}
