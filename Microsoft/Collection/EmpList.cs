using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Classwork.Collection
{
    class EmpList
    {
        public int id { get; set; }
        public String Ename { get; set; }
        public int Salary { get; set; }
        static void Main(string[] args)
        {
            List<EmpList> EmployeeList = new List<EmpList>()
            {
                new EmpList{id=1,Ename="Pooja",Salary=30000},
                new EmpList{id=2,Ename="Priti",Salary=35000},
                new EmpList{id=3,Ename="Purva",Salary=20000},

            };
            foreach (EmpList item in EmployeeList)
            {
                Console.WriteLine($"{item.id} {item.Ename} {item.Salary}");
            }
            Console.ReadLine();
        }
    }
    class Product
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public int Productprice { get; set; }
        static void Main(string[] args)
        {
            List<Product> prodLists = new List<Product>()
            {
                 new Product { Productid = 1, Productname = "Hp laptop", Productprice = 37000 },
                 new Product { Productid = 2, Productname = "Dell laptop", Productprice = 50000 },
                 new Product { Productid = 3, Productname = "Lenovo laptop", Productprice = 63000 }
            };
            foreach (Product item in prodLists)
            {
                Console.WriteLine($"{item.Productid} {item.Productname} {item.Productprice}");
            }

            Console.ReadLine();

        }
    }
    


}
