using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Pen
    {
        int PenId;
        String PenName;
        String PenBrand;
        String PenType;
        String PenColor;
        int PenPrice;

        public Pen()
        {
            Console.WriteLine("In Pen Constructor");
        }
        public int Penid
        {
            get { return PenId; }
            set { PenId = value; }
        }
        public string Penname
        {
            get { return PenName; }
            set { PenName = value; }
        }
        public string Penbrand
        {
            get { return PenBrand; }
            set { PenBrand = value; }
        }
        public string Pentype
        {
            get { return PenType; }
            set { PenType = value; }
        }
        public string Pencolor
        {
            get { return PenColor; }
            set { PenColor = value; }
        }
        public int Penprice
        {
            get { return PenPrice; }
            set { PenPrice = value; }
        }
        public Pen(int pid)
        {
            PenId = pid;
        }
        public Pen(int pid,string pname,string pbrand, string ptype,string pcolor,int price)
        {
            PenId = pid;
            PenName = pname;
            PenBrand = pbrand;
            PenType = ptype;
            PenColor = pcolor;
            PenPrice = price;
        }
        public void SetPenId(int penid)
        {
            PenId = penid;

        }
        public int GetPenId()
        {
            return PenId;
        }
        public void SetPenName(string penname)
        {
            PenName = penname;
        }
        public string GetPenName()
        {
            return PenName;
        }
        public void SetPenBrand(string penbrand)
        {
            PenBrand = penbrand;
        }
        public string GetPenBrand()
        {
            return PenBrand;
        }
        public void SetPenType(string pentype)
        {
            PenType = pentype;
        }
        public string GetPenType()
        {
            return PenType;
        }
        public void SetPenColor(string pencolor)
        {
            PenColor = pencolor;
        }
        public string GetPenColor()
        {
            return PenColor;
        }
        public void SetPenPrice(int penprice)
        {
            PenPrice = penprice;
        }
        public int GetPenPrice()
        {
            return PenPrice;
        }
        public int add(int a, int b)
        {
            return a + b;

        }
        public int add(int a, int b, int c)
        {
            return a + b + c;

        }
        static void Main(string[] args)
        {
            Pen p = new Pen(101);
            //Constructor
            p.SetPenId(101);
            Console.WriteLine("Pen Id "+p.GetPenId());

            p.SetPenId(1);
            p.SetPenName("Trimax");
            p.SetPenType("Gel");
            p.SetPenBrand("Reynold");
            p.SetPenColor("Blue");
            p.SetPenPrice(25);

            Console.WriteLine("----------------------------------");
            int pid = p.GetPenId();
            string pname = p.GetPenName();
            string ptype = p.GetPenType();
            string pbrand = p.GetPenBrand();
            string pcolor = p.GetPenColor();
            int pprice = p.GetPenPrice();

            Console.WriteLine("Pen Id " + pid);
            Console.WriteLine(" Pen Name " + pname);
            Console.WriteLine(" Pen Type " + ptype);
            Console.WriteLine(" Pen Brand " + pbrand);
            Console.WriteLine("Pen color " + pcolor);
            Console.WriteLine(" Pen Price " + pprice);

            Console.WriteLine("------------------------------------");

            Pen p1 = new Pen(2,"Montex","Gel","REynold","Black",20);
           

            Console.WriteLine("Enter Pen Id");
            int pid1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Pen Name");
            string pname1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Pen type");
            string ptype1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Pen Brand");
            string pbrand1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Pen Color");
            string pcolor1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Pen Price");
            int pprice1 = Convert.ToInt32(Console.ReadLine());


            p1.SetPenId(pid1);
            p1.SetPenName(pname1);
            p1.SetPenType(ptype1);
            p1.SetPenBrand(pbrand1);
            p1.SetPenColor(pcolor1);
            p1.SetPenPrice(pprice1);

            Console.WriteLine("Pen Id: " + p1.GetPenId() + "Pen Name: " + p1.GetPenName() + "Pen Type: " + p1.GetPenType() + "Pen Brand: " + p1.GetPenBrand() + "Pen Color: " + p1.GetPenColor() + "Pen Price: " + p1.GetPenPrice());


            Console.Read();




        }
       
        

    }
    class Pen1
    {
        static void Main(string[] args)
        {
            Pen pp = new Pen();
            pp.Penid = 1;
            pp.Penname="cello";
            pp.Penprice = 10;
            pp.Pentype = "BolPen";
            pp.Pencolor = "Blue";
            Console.WriteLine(pp.Penid);
            Console.WriteLine(pp.Penname);
            Console.WriteLine(pp.Penprice);
            Console.WriteLine(pp.Pentype);
            Console.WriteLine(pp.Pencolor);
            Console.ReadLine();

        }
       
    }
}
