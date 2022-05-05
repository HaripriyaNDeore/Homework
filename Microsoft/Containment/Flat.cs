using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class Flat
    {
        int flatno;
        string buildingname;
        Owner flatowner = new Owner();

        public Flat()
        {

        }

        public Flat(int flatno, string buildingname)
        {
            this.Flatno = flatno;
            this.Buildingname = buildingname;
        }
        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Owner Flatowner { get => flatowner; set => flatowner = value; }
      


    }
    class Owner
    {
        string ownername;
        int age;
        string profession;
        char gender;

        public Owner()
        {
            
        }

        public Owner(string ownername, int age, string profession, char gender)
        {
            this.Ownername = ownername;
            this.Age = age;
            this.Profession = profession;
            this.Gender = gender;
        }

        public char Gender { get => gender; set => gender = value; }
        public string Profession { get => profession; set => profession = value; }
        public int Age { get => age; set => age = value; }
        public string Ownername { get => ownername; set => ownername = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Flat f = new Flat();
            f.Buildingname = "purva";
            f.Flatno = 1;
            f.Flatowner.Ownername = "Pooja";
            f.Flatowner.Age = 30;
            f.Flatowner.Profession = "teacher";
            f.Flatowner.Gender = 'F';
            Console.WriteLine("Flat No :"+ f.Flatno);
            Console.WriteLine("Building Name : " + f.Buildingname);
            Console.WriteLine("Flat Owner Name :" + f.Flatowner.Ownername);
            Console.WriteLine("Flat Owner Age : " + f.Flatowner.Age);
            Console.WriteLine("Flat Owner Age Profession :" + f.Flatowner.Profession);
            Console.WriteLine("Flat Owner Gender : " + f.Flatowner.Gender);
            Console.ReadLine();


        }

    }
}
