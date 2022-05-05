using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Containment
{
    class ItemI
    {
        int itemid;
        String itemname;
        int price;

        public ItemI()
        {
            Console.WriteLine("In ItemI Constructor");
        }
        public ItemI(int itemid, string itemname, int price)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
            this.Price = price;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Price { get => price; set => price = value; }
    }
}
