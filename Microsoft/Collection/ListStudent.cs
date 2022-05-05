using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    class ListStudent
    {
        
        public int Sid { get; set; }
        public string Sname { get ; set; }
        public string Sclass { get ; set; }

        static void Main(string[] args)
        {
            List<ListStudent> listStudents = new List<ListStudent>()
            {
                new ListStudent{Sid=1,Sname="Priyanka",Sclass="V"},
                new ListStudent{Sid=2,Sname="Priya",Sclass="VIII"},
                new ListStudent{Sid=3,Sname="Ankita",Sclass="X"}

            };
            foreach (ListStudent stud in listStudents)
            {
                Console.WriteLine($"{stud.Sid} {stud.Sname} {stud.Sclass}");
            }
            Console.ReadLine();
        }
    }
}
