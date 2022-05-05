using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Inherit
{
    class Refill:Pen
    {

        string inkColor;
        int length;
        string Nib;

        public Refill()
        {
            Console.WriteLine("In Refill Constructor");
        }
        public Refill(string inkColor, int length, string nib)
        {
            this.InkColor = inkColor;
            this.Length = length;
            Nib1 = nib;
        }

        public string InkColor { get => inkColor; set => inkColor = value; }
        public int Length { get => length; set => length = value; }
        public string Nib1 { get => Nib; set => Nib = value; }
    }
}
