using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class Order
    {
        int orderid;
        string orderdate;
        string orderitem;
        Customer cust = new Customer();
        Address1 add = new Address1();
        Item it = new Item();


        public Order()
        {

        }

        public Order(int orderid,string orderdate,string orderitem)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.orderitem = orderitem;
        }
       
        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public string Orderitem { get => orderitem;set=>orderitem= value; }
        public Customer Cust { get => cust; set => cust = value; }
        public Address1 Add { get => add; set => add = value; }
        public Item It { get => it; set => it = value; }
    }
    class Customer
    {
        int custid;
        string custname;
        string custaddress;
        string mailid;
        long mno;
        public Customer()
        {

        }
        public Customer(int custid,string custname,string custaddress,string mailid,long mno)
        {
            this.custid = custid;
            this.custname = custname;
            this.custaddress = custaddress;
            this.mailid = mailid;
            this.mno = mno;
        }
        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        public string Custaddress { get => custaddress; set => custaddress = value; }
        public string Mailid { get => mailid; set => mailid = value; }
        public long Mno { get => mno; set => mno = value; }


    }
    class Address1
    {
        string address;
        string area;
        string city;
        string tal;
        string dist;
        long pin;
        public Address1()
        {

        }

        public Address1(string address, string area, string city, string tal, string dist, long pin)
        {
            this.Address = address;
            this.Area = area;
            this.City = city;
            this.Tal = tal;
            this.Dist = dist;
            this.Pin = pin;
        }

        public string Address { get => address; set => address = value; }
        public string Area { get => area; set => area = value; }
        public string City { get => city; set => city = value; }
        public string Tal { get => tal; set => tal = value; }
        public string Dist { get => dist; set => dist = value; }
        public long Pin { get => pin; set => pin = value; }
    }
    class Item
    {
        int itemid;
        string itemname;
        public Item()
        {

        }
        public Item(int itemid,string itemname)
        {
            this.itemid = itemid;
            this.itemname = itemname;
        }
        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        

    }
    class OTest
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Orderid = 1;
            o.Orderitem = "Mobile";
            o.Orderdate="6April";
            o.Cust.Custid = 121;
            o.Cust.Custname = "Priya";
            o.Cust.Custaddress = "At post nashik";
            o.Cust.Mailid = "priya@gmail.com";
            o.Cust.Mno = 9132121123;
            o.Add.Area = "Dk";
            o.Add.Address = "Ekta Chauk";
            o.Add.City = "Nashik";
            o.Add.Dist = "Nashik";
            o.Add.Pin = 123221;
            Console.WriteLine("Order Id: "+o.Orderid);
            Console.WriteLine("Order Item: "+o.Orderitem);
            Console.WriteLine("Order Date: "+o.Orderdate);
            Console.WriteLine("Customer Id: "+o.Cust.Custid);
            Console.WriteLine("Customer Name: "+o.Cust.Custname);
            Console.WriteLine("Customer Address: "+o.Cust.Custaddress);
            Console.WriteLine("Customer MailId: "+o.Cust.Mailid);
            Console.WriteLine("Customer Mobile Number: "+o.Cust.Mno);
            Console.WriteLine("Area :"+o.Add.Area);
            Console.WriteLine("Address "+o.Add.Address);
            Console.WriteLine("City :"+o.Add.City);
            Console.WriteLine("Dist: "+o.Add.Dist);
            Console.WriteLine("Pin: "+o.Add.Pin);


            Console.ReadLine();
        }
    }
}
