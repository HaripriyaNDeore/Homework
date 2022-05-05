using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class Customer1
    {
        int custid;
        String custname;
        string address;

        public Customer1()
        {
           Console.WriteLine("In Customer1"); 
        }

        public Customer1(int custid, string custname, string address)
        {
            this.Custid = custid;
            this.Custname = custname;
            this.Address = address;

        }


        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        public string Address { get => address; set => address = value; }
    }
}
