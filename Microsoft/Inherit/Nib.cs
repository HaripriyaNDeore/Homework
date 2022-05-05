using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Nib:Pen
    {
        string materialType;
        int width;
        public Nib()
        {
            Console.WriteLine("In Nib Deafult Constructor");
        }

        public Nib(string materialType, int width)
        {
            this.MaterialType = materialType;
            this.Width = width;
        }

        public string MaterialType { get => materialType; set => materialType = value; }
        public int Width { get => width; set => width = value; }
    }
    class nib1
    {
        static void Main(string[] args)
        {
            Pen pp = new Pen();
            pp.CapLength=3;
            pp.Brand = "cello";

            Refill r = new Refill();
            r.InkColor = "red";
            r.Length = 3;
            r.Nib1 = "point";

            Nib n = new Nib();
            n.MaterialType = "metal";
            n.Width = 3;


            Console.WriteLine($"Pen Cap Length={pp.CapLength},Pen Brand={pp.Brand},Pen Ink Color={r.InkColor},Pen Length={r.Length},Pen Nib={r.Nib1},Pen Material Type={n.MaterialType},Pen Width={n.Width}"); 
            Console.ReadLine();
        }
    }
}
