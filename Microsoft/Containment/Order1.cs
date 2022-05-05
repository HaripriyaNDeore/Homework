using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class Order1
    {
        int ordered;
        string Orderdate;
        Customer1 cust;
        AddressA add;
        ItemI item;
        public Order1()
        {
            Console.WriteLine("In Order1 Constructor");
        }

        public Order1(int ordered, string orderdate, Customer1 cust, AddressA add, ItemI item)
        {
            this.Ordered = ordered;
            Orderdate1 = orderdate;
            this.Cust = cust;
            this.Add = add;
            this.Item = item;
        }

        public int Ordered { get => ordered; set => ordered = value; }
        public string Orderdate1 { get => Orderdate; set => Orderdate = value; }
        internal Customer1 Cust { get => cust; set => cust = value; }
        internal AddressA Add { get => add; set => add = value; }
        internal ItemI Item { get => item; set => item = value; }
    }
    class OrdTest
    {
        static void Main(string[] args)
        {
            Order1 o = new Order1();
            o.Ordered = 1;
            o.Orderdate1 = "3";
            o.Cust.Custid = 2;
            o.Cust.Custname = "riya";
            o.Cust.Address = "Nashik";
            o.Add.Addr1 = "MG Road";
            o.Add.City = "Malegaon";
            o.Add.Pincode = 423203;
            o.Item.Itemid = 102;
            o.Item.Itemname = "Bag";
            o.Item.Price = 500;
            Console.WriteLine($"Ordered Number={o.Ordered},Ordered date={o.Orderdate1},Customer Id={o.Cust.Custid},Customer name={o.Cust.Custname}");
            Console.WriteLine($"Address={o.Cust.Address},Addr1={o.Add.Addr1 },City={o.Add.City},Pincode={o.Add.Pincode}");
            Console.WriteLine($"Item Id={o.Item.Itemid},Item Name={o.Item.Itemname},Item Price={o.Item.Price}");
            Console.ReadLine();

        }
    }
}
