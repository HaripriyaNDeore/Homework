using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Teacher
    {
        int tid;
        string tname;
        int experience;
        long salary;

        public Teacher()
        {
            Console.WriteLine("In Teacher Default Constructor");
        }
        public Teacher(int tid,string tname,int experience,long salary)
        {
            this.tid = tid;
            this.tname = tname;
            this.experience = experience;
            this.salary = salary;

        }
        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public int Experience { get => experience; set => experience = value; }
        public long Salary { get => salary; set => salary = value; }

    }
   
}
