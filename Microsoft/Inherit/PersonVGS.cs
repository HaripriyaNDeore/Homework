using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class PersonVGS
       {
        int pid;
        String name;
        Vehicle v = new Vehicle();

        public PersonVGS()
        {
            Console.WriteLine("In Default Constructor");
        }

        public PersonVGS(int id, string nm, Vehicle v)
        {
            this.pid = id;
            this.name = nm;
            this.v = v;

        }
        public void setId(int id)
        {
            pid = id;
        }

        public int getId()
        {
            return pid;

        }
        public void setName(string nm)
        {
            name = nm;
        }

        public string getName()
        {
            return name;

        }

    }
    class Vehicle
    {

    }



    class Person_vehical
    {
        static void Main(string[] args)
        {
            PersonVGS p = new PersonVGS();
            Console.WriteLine("Enter The Id");
            int i = Convert.ToInt32(Console.ReadLine());
            p.setId(i);

            Console.WriteLine("Enter The Name");
            string s = Console.ReadLine();
            p.setName(s);



        }
    }

}