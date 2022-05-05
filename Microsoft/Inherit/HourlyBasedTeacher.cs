using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
   class HourlyBasedTeacher:Teacher
    {
        int hour;
        int rate;
        public HourlyBasedTeacher()
        {
            Console.WriteLine("In HourlyBasedTeacher Default Constructor");
        }

        public HourlyBasedTeacher(int hour, int rate)
        {
            this.Hour = hour;
            this.Rate = rate;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Rate { get => rate; set => rate = value; }
    }
    class TTesst
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.Tid = 1;
            t.Tname = "Pooja";
            t.Salary = 20000;
            t.Experience = 10;

            PermanantTeacher p1 = new PermanantTeacher();
            p1.Tid = 2;
            p1.Tname = "Vaishanavi";
            p1.Salary = 25000;
            p1.Experience = 12;
            p1.Subject = "c";

            HourlyBasedTeacher h = new HourlyBasedTeacher();
            h.Tid = 3;
            h.Tname = "Diya";
            h.Salary = 25000;
            h.Experience = 13;
            h.Hour= 1;
            h.Rate = 2000;

            Console.WriteLine($"Teacher Id={h.Tid},Teacher Name={h.Tname},Teacher Salary={h.Salary},Teacher Experience={h.Experience},Teacher Hour={h.Hour},Teacher Rate={h.Rate}");
            Console.ReadLine();
        }
    }
}
