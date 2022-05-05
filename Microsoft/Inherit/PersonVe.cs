using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class PersonVe
    {
        int id; 
        String name;
        vehicle v;
        public PersonVe()
        {
            Console.WriteLine("In person constructor");
        }

        public PersonVe(int id, string name, vehicle v)
        {
            this.Id = id;
            this.Name = name;
            this.V = v;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal vehicle V { get => v; set => v = value; }
    }
    class vehicle: PersonVe
    {
        int vid;
        String vname;
        public vehicle()
        {
            Console.WriteLine("In vehicle constructor");
        }

        public vehicle(int vid, string vname)
        {
            this.Vid = vid;
            this.Vname = vname;
        }

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
    }
    class TTest
    {
        static void Main(string[] args)
        {
            PersonVe p = new PersonVe();
            p.Id = 1;
            p.Name = "riya";

            vehicle v = new vehicle();
            v.Id = 1;
            v.Name = "Honda";

            Console.WriteLine($"Person Id={p.Id },Person Name={p.Name},vehicle Id={v.Id},vehicle Id={v.Name}");

            Console.WriteLine("Enter The Person Id");
            p.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Person Name");
            p.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter The Vehicle Id");
            v.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Vehicle Name");
            v.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Person Id={p.Id },Person Name={p.Name},vehicle Id={v.Id},vehicle Id={v.Name}");
            Console.ReadLine();

        }
        




    }
}
