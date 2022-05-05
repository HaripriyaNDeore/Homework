using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Collection
{
    class ListDept
    {
        public int Did { get; set; }
        public string Dname { get; set; }
        public string DIncharge { get; set; }

        static void Main(string[] args)
        {
            List<ListDept> listDepartment = new List<ListDept>()
            {
                new ListDept{Did=1,Dname="Computer Science",DIncharge="Nikam"},
                new ListDept{Did=2,Dname="Mechanical",DIncharge="Pawar"},
                new ListDept{Did=3,Dname="Automobile",DIncharge="Patil"}

            };
            foreach (ListDept dept in listDepartment)
            {
                Console.WriteLine($"{dept.Did} {dept.Dname} {dept.DIncharge}");
            }
            Console.ReadLine();
        }
    }
}
