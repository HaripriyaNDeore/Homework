using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Student
    {
        private int age;
        private string name;
        private float percent;
        public void SetAge(int ag)
        {
            age = ag;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetName(string nm)
        {
            name = nm;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPercent(float per)
        {
            percent = per;
        }
        public float GetPercent()
        {
            return percent;
        }


    }
    class Student1
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetAge(1);
            s.SetName("Priya");
            s.SetPercent(20);

            int ag1 = s.GetAge();
            string a = s.GetName();
            float per1 = s.GetPercent();

            Console.WriteLine("Student Age: " + ag1 + "Student Name: " + a + "Student Percentage: " + per1);

            Student ss = new Student();
            Console.WriteLine("Enter Student Age");
            int sage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string sname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Student Percentage");
            float sper = Convert.ToInt32(Console.ReadLine());
            ss.SetAge(sage);
            ss.SetName(sname);
            ss.SetPercent(sper);
            Console.WriteLine("Student Age: " + ss.GetAge() + "Student Name: " + ss.GetName() + "Student Percentage: " + ss.GetPercent());

            Console.WriteLine(a);
        }
    }
}
