using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Classwork.Delegatess
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public double fees { get; set; }
    }
    class LinqCourse
    {
        static void Main(string[] args)
        {

            List<Course> courselist = new List<Course>()
            {
                new Course{id=1,name="c++ ",fees=24376},
               new Course{id=2,name="Java ",fees=15000},
               new Course{id=3,name="c# ",fees=36000},
               new Course{id=4,name="c# ",fees=30000},
               new Course{id=5,name="Php ",fees=20000},
               new Course{id=6,name="java ",fees=15000},
               new Course{id=7,name="php ",fees=20000},
            };
            //1.display course whose fees is greater than 20000
            var res = from c in courselist
                      where c.fees > 20000
                      select c;
            //  2.display all course accesending order by their name
            var res1 = from c in courselist
                       orderby c.name
                       select c;
            //  3.display course whoes fees is 20000
            var res3 = from c in courselist
                       where c.fees == 20000
                       select c;
            // 4.display course who name is c++
            var res4 = from c in courselist
                       where c.name.Contains("c++")
                       select c;
            //  5.display all course orderby fees desending

            var res5 = from c in courselist
                       orderby c.fees descending
                       select c;
            // 6.display course whos name start with 'C'

            var res6 = from c in courselist
                       where c.name.StartsWith('C') || c.name.StartsWith('c') 
                       select c;



            //1.display course whose fees is greater than 20000
            Console.WriteLine("---------------------------------display course whose fees is greater than 20000-------------------------------------");
            foreach (Course c in courselist)
            {
                Console.WriteLine($"{c.id}{c.name}{c.fees}");
            }
            //  2.display all emp accesending order by their name
            Console.WriteLine("---------------------------------display all course accesending order by their name-------------------------------------");
            foreach (Course c in courselist)
            {
                Console.WriteLine($"{c.id}{c.name}{c.fees}");
            }
            //  3.display course whoes fees is 20000
            Console.WriteLine("---------------------------------display course whoes fees is 20000------------------------------------");
            foreach (Course c in courselist)
            {
                Console.WriteLine($"{c.id}{c.name}{c.fees}");
            }
            // 4.display course who name is c++
            Console.WriteLine("---------------------------------display course who name is c++-------------------------------------");
            foreach (Course c in courselist)
            {
                Console.WriteLine($"{c.id}{c.name}{c.fees}");
            }
            //  5.display all course orderby fees desending
            Console.WriteLine("---------------------------------display all course orderby fees desending-------------------------------------");
            foreach (Course c in courselist)
            {
                Console.WriteLine($"{c.id}{c.name}{c.fees}");
            }
            // 6.display course whos name start with 'C'
            Console.WriteLine("---------------------------------display course whos name start with 'C'-------------------------------------");
            foreach (Course c in courselist)
            {
                Console.WriteLine($"{c.id}{c.name}{c.fees}");
            }
        }

    }
}
