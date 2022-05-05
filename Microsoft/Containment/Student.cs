using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class Student
    {
        int studid;
        string studname;
        int per;
        Batch batch = new Batch();
        Address address = new Address();
        public Student()
        {

        }

        public Student(int studid, string studname, int per)
        {
            this.Studid = studid;
            this.Studname = studname;
            this.Per = per;
        }
       

        public int Per { get => per; set => per = value; }
        public int Studid { get => studid; set => studid = value; }
        public string Studname { get => studname; set => studname = value; }
        internal Address Address { get => address; set => address = value; }
        internal Batch Batch { get => batch; set => batch = value; }
    }
    class Address
    {
        string city;
        string area;

        public Address()
        {

        }
        public Address(string city ,string area)
        {
            this.City = city;
            this.Area = area;
        }
       
        public string Area { get => area; set => area = value; }
        public string City { get => city; set => city = value; }
    }
    class Batch
    {
        string name;
        string subject;
        
        public string Subject { get => subject; set => subject = value; }
        public string Name { get => name; set => name = value; }

        public Batch()
        {

        }
        public Batch(string name,string subject)
        {
            this.Name = name;
            this.Subject = subject;
        }

       
    }
    class Student1
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Studid = 1;
            st.Studname = "Priya";
            st.Batch.Name = "Microsoft";
            st.Batch.Subject = "c#";
            st.Address.Area = "MG Raod";
            st.Address.City = "Nashik";
            Console.WriteLine("Student Name "+st.Studid);
            Console.WriteLine("Student Name "+st.Studname);
            Console.WriteLine("Student Batch "+ st.Batch.Name);
            Console.WriteLine("Student Subject " + st.Batch.Subject);
            Console.WriteLine("Student Area " + st.Address.Area);
            Console.WriteLine("Student City "+ st.Address.City);

            Console.ReadLine();
        }
    }
}
