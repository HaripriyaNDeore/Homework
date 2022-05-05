using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Classwork.Delegatess
{
    public class Emp
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double salary { get; set; }

        public string dept { get; set; }
    }
    class LinqEmployee
    {
        static void Main(string[] args)
        {
            List<Emp> emplist = new List<Emp>()
            {
                new Emp{id=1,name="Priya ",city="Nashik ",salary=30000,dept="IT "},
               new Emp{id=2,name="Kairavi ",city="mumbai ",salary=35000,dept="production "},
               new Emp{id=3,name="Ankita ",city="pune ",salary=45000,dept="ENTC "},
               new Emp{id=4,name="riya ",city="Nashik ",salary=15000,dept="IT "},
               new Emp{id=5,name="vaivbhav ",city="pune ",salary=30000,dept="HR "},
               new Emp{id=6,name="Priya ",city="mumbai ",salary=50000,dept="IT "},
               new Emp{id=7,name="Priyanka ",city="pune ",salary=30000,dept="HR "},
            };
          //  1.display emp whose salary is greater than 45000
            var res = from e in emplist
                      where e.salary > 45000 
                      select e;
          //  2.display all emp accesending order by their name
           var res1 = from e in emplist
                       orderby e.name
                       select e;
          //  3.display emps who lives in mumbai city

            var res2 = from e in emplist
                       where e.city.Contains("mumbai")
                       select e;
           // 4.display emps who belongs to HR dept

            var res3 = from e in emplist
                       where e.dept.Contains("HR")
                       select e;
          //  5.display all emps orderby salary desending

           var res4 = from e in emplist
                       orderby e.salary descending
                       select e;
           // 6.display emp whos name start with 'a' or 'k'

            var res5 = from e in emplist
                       where e.name.StartsWith('a') || e.name.StartsWith('A') || e.name.StartsWith('k') || e.name.StartsWith('K')
                       select e;

          //  7.display emps beglogs to pune city & salary < 35000

            var res6 = from e in emplist
                       where e.city.Contains("pune") && e.salary < 35000
                       select e;


            //  1.display emp whose salary is greater than 45000
            Console.WriteLine("--------------emp whose salary is greater than 45000---------------------------------");
            foreach (Emp e in res)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
            //  2.display all emp accesending order by their name
            Console.WriteLine("--------------display all emp accesending order by their name---------------------------------");
            foreach (Emp e in res1)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
            // 3.display emps who lives in mumbai city
            Console.WriteLine("--------------display emps who lives in mumbai city---------------------------------");
            foreach (Emp e in res2)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
            //  4.display emps who belongs to HR dept
            Console.WriteLine("--------------display emps who belongs to HR dept---------------------------------");
            foreach (Emp e in res3)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
            // 5.display all emps orderby salary desending
            Console.WriteLine("--------------display all emps orderby salary desending---------------------------------");
            foreach (Emp e in res4)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
            //  6.display emp whose name start with 'a' or 'k'
            Console.WriteLine("--------------emp whose name start with 'a' or 'k'---------------------------------");
            foreach (Emp e in res5)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
            //  7.display emps beglogs to pune city & salary < 35000
            Console.WriteLine("--------------emps beglogs to pune city & salary < 35000--------------------------------");
            foreach (Emp e in res6)
            {
                Console.WriteLine($"{e.id}{e.name}{e.city}{e.salary}{e.dept}");
            }
          
        }
    }
}
