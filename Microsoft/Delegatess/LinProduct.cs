using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Classwork.Delegatess
{
    public class Product
    {
        public int pid { get; set; }
        public String pname { get; set; }
        public double pprice { get; set; }
    }
    class LinProduct
    {
        static void Main(string[] args)
        {
            List<Product> prodlist = new List<Product>()
            {
                new Product{pid=1,pname="mobile",pprice=17000},
                new Product{pid=2,pname="dell laptop",pprice=60000},
                new Product{pid=3,pname="Refrigerator",pprice=18000},
                new Product{pid=4,pname="TV",pprice=45000},
                new Product{pid=5,pname="Refrigerator",pprice=18000},
                new Product{pid=6,pname="dell",pprice=45000},
                new Product{pid=7,pname="mobile",pprice=18000},
            };
            
            var res = from p in prodlist
                      where p.pprice > 18000 && p.pprice<60000
                      where p.pname.StartsWith('l')&&p.pname.StartsWith('L')
                      where p.pname.Contains("dell")
                      orderby p.pprice descending
                      orderby p.pname
                      select p;
            foreach (Product p in prodlist)
            {
                Console.WriteLine($"{p.pid}{p.pname}{p.pprice}");
            }
        }
    }
}
