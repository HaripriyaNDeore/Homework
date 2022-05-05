using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Course
    {
        int courseid;
        string coursename;
        int coursestudent;
        Student[] s = new Student[10];
        public Course()
        {

        }

       

        public Course(int courseid, string coursename, int coursestudent)
        {
            this.Courseid = courseid;
            this.Coursename = coursename;
            this.Coursestudent = coursestudent;
            
        }

        public int Courseid { get => courseid; set => courseid = value; }
        public string Coursename { get => coursename; set => coursename = value; }
        public int Coursestudent { get => coursestudent; set => coursestudent = value; }
        internal Student[] S { get => s; set => s = value; }
    }
    class Student:Course
    {
        int studentid;
        string studentname;
        string studentcourse;

        public Student()
        {

        }

        public Student(int studentid, string studentname, string studentcourse)
        {
            this.Studentid = studentid;
            this.Studentname = studentname;
            this.Studentcourse = studentcourse;
        }

        public int Studentid { get => studentid; set => studentid = value; }
        public string Studentname { get => studentname; set => studentname = value; }
        public string Studentcourse { get => studentcourse; set => studentcourse = value; }
        int[] Student1 = new int[10];


    }
    class Test
    {
        static void Main(string[] args)
        {
            Student[] s1 = new Student[]
                        { new Student(1,"riya","c#"),
                        new Student(2,"raj","java"),
                        new Student(3,"priya","c#"),
                        new Student(4,"kiya","c#"),
                        new Student(5,"nitin","c#"),
                        new Student(6,"mahesh","java"),
                        new Student(7,"kalyani","java"),
                        new Student(8,"dipa","c#"),
                        new Student(9,"rupa","java"),
                        new Student(10,"rajesh","java"),
                       };
            Course c = new Course(1, "c#", 5);
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(c.S[i].Studentname);


            Console.ReadLine();
        }
        




    }
}
