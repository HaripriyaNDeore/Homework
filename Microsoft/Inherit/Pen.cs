using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Pen
    {
        int Refill;
        int capLength;
        string brand;

        public Pen()
        {
            Console.WriteLine("In Pen Default Constructor");
        }

        public Pen(int refill, int capLength, string brand)
        {
            Refill1 = refill;
            this.CapLength = capLength;
            this.Brand = brand;
        }

        public int Refill1 { get => Refill; set => Refill = value; }
        public int CapLength { get => capLength; set => capLength = value; }
        public string Brand { get => brand; set => brand = value; }
    }
}
