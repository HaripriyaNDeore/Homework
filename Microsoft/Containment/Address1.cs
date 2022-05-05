using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class AddressA
    {
        string addr1;
        string city;
        int pincode;
        public AddressA()
        {
            Console.WriteLine("In AddressA Constructor");
        }
        public AddressA(string addr1, string city, int pincode)
        {
            this.Addr1 = addr1;
            this.City = city;
            this.Pincode = pincode;

        }

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
}
