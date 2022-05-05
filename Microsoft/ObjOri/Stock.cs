using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Stock
    {
        int OpeningPrice;
        int ClosingPrice;
        string StockName;
        public int OpeningP
        {
            get { return OpeningPrice; }
            set { OpeningPrice = value; }
        }
        public int ClosingP
        {
            get { return ClosingPrice; }
            set { ClosingPrice = value; }
        }
        public string StockN
        {
            get { return StockName; }
            set { StockName = value; }
        }
        public Stock()
        {
            Console.WriteLine("In stock Constructor");
        }
        public void SetOpeningPrice(int oprice)
        {
            OpeningPrice = oprice;
        }
        public int GetOpeningPrice()
        {
            return OpeningPrice;
        }
        public void SetClosingPrice(int cprice)
        {
            ClosingPrice = cprice;
        }
        public int GetClosingPrice()
        {
            return ClosingPrice;
        }
        public void SetStockName(string sname)
        {
            StockName = sname;
        }
        public string GetStockName()
        {
            return StockName;
        }
        static void Main(string[] args)
        {
                Stock s = new Stock();
                s.SetOpeningPrice(1232);
                s.SetClosingPrice(1213);
                s.SetStockName("pen");
                Console.WriteLine("----------------------------------");
                int soprice = s.GetOpeningPrice();
                int scprice = s.GetClosingPrice();
                string sname = s.GetStockName();

                Console.WriteLine("Stock opening Price " + soprice);
                Console.WriteLine(" Stock closing Price " + scprice);
                Console.WriteLine(" Stock Name " + sname);

                Console.WriteLine("------------------------------------");

                Stock s1 = new Stock();
                Console.WriteLine("Enter Stock Opening Price");
                int soprice1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Stock Closing Price");
                int coprice1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Stock Name");
                string sname1 = Convert.ToString(Console.ReadLine());

                s1.SetOpeningPrice(soprice1);
                s1.SetClosingPrice(coprice1);
                s1.SetStockName(sname1);

                Console.WriteLine("Opening Price: " + s1.GetOpeningPrice() + "Closing Price: " + s1.GetClosingPrice() + "Stock Name: " + s1.GetStockName());
                Console.Read();
            }
    }
    class Stock1
    {
        static void Main(string[] args)
        {
            Stock s1 = new Stock();
            s1.OpeningP = 123;
            Console.WriteLine(s1.OpeningP);
            s1.ClosingP = 233;
            Console.WriteLine(s1.ClosingP);
            s1.StockN = "abc";
            Console.WriteLine(s1.StockN);
        }
    }
   
 }

