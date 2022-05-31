using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Classwork.Delegatess
{
    public class Student
    {
        public int rno { get; set; }
        public string name { get; set; }
        public double percentage { get; set;}
        public string branch { get; set; }
    }
    class LinStudent
    {
        static void Main(string[] args)
        {
            List<Student> studlist = new List<Student>()
            {
                new Student{rno=1,name="Anjali ",percentage=66.67,branch="IT"},
               new Student{rno=2,name="Nikita ",percentage=75,branch="ENTC"},
                new Student{rno=3,name="Shweta ",percentage=88,branch="civil"},
               new Student{rno=4,name="Anushka ",percentage=81,branch="IT"},
               new Student{rno=5,name="Hetal ",percentage=77,branch="Computer"},
               new Student{rno=6,name="Supriya ",percentage=90,branch="Computer"},
               new Student{rno=7,name="Nikita ",percentage=69,branch="civil"},
            };
            //1.display student whose percentage is  greater than 75
            var res = from s in studlist
                      where s.percentage > 75
                      select s;
            //  2.display all student name accesending order by their name
            var res1 = from s in studlist
                       orderby s.name
                       select s;
            //  3.display student whoes rno is 3
            var res3 = from s in studlist
                       where s.rno == 3
                       select s;
            // 4.display student who name is nikita
            var res4 = from s in studlist
                       where s.name.Contains("Nikita")
                       select s;
            //  5.display all student orderby percentage desending

            var res5 = from s in studlist
                       orderby s.percentage descending
                       select s;
            // 6.display student whos branch start with 'C'

            var res6 = from s in studlist
                       where s.name.StartsWith('C') || s.name.StartsWith('c')
                       select s;



            //1.display student whose percentage is  greater than 75
            Console.WriteLine("---------------------------------display student whose percentage is  greater than 75-------------------------------------");
            foreach (Student s in studlist)
            {
                Console.WriteLine($"{s.rno}{s.name}{s.percentage}{s.branch}");
            }
            //  2.display all student name accesending order by their name
            Console.WriteLine("---------------------------------display all student name accesending order by their name-------------------------------------");
            foreach (Student s in studlist)
            {
                Console.WriteLine($"{s.rno}{s.name}{s.percentage}{s.branch}");
            }
            //  3.display student whoes rno is 3
            Console.WriteLine("---------------------------------display student whoes rno is 3------------------------------------");
            foreach (Student s in studlist)
            {
                Console.WriteLine($"{s.rno}{s.name}{s.percentage}{s.branch}");
            }
            // 4.display student who name is nikita
            Console.WriteLine("---------------------------------display student who name is nikita-------------------------------------");
            foreach (Student s in studlist)
            {
                Console.WriteLine($"{s.rno}{s.name}{s.percentage}{s.branch}");
            }
            //  5.display all student orderby percentage desending
            Console.WriteLine("---------------------------------display all student orderby percentage desending-------------------------------------");
            foreach (Student s in studlist)
            {
                Console.WriteLine($"{s.rno}{s.name}{s.percentage}{s.branch}");
            }
            // 6.display student whos branch start with 'C'
            Console.WriteLine("---------------------------------display student whos branch start with 'C'-------------------------------------");
            foreach (Student s in studlist)
            {
                Console.WriteLine($"{s.rno}{s.name}{s.percentage}{s.branch}");
            }
        }
    }
}
