using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    class ListCourse
    {
        public int Cid { get; set; }
        public string Cname { get; set; }

        static void Main(string[] args)
        {
            List<ListCourse> listCourse = new List<ListCourse>()
            {
                new ListCourse{Cid=1,Cname="Computer Science"},
                new ListCourse{Cid=2,Cname="Mechanical"},
                new ListCourse{Cid=3,Cname="Automobile"}

            };
            foreach (ListCourse course in listCourse)
            {
                Console.WriteLine($"{course.Cid} {course.Cname} ");
            }
            Console.ReadLine();
        }
    }
}
