using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Account1
    {
        public Account1()
        {
            Console.WriteLine("I am in default Constructor");
        }
        public long accountNo;
        public String customerName;
        public void SetAccountNo(long accno)
        {
            accountNo = accno;
        }
        public long GetAccountNo()
        {
            return accountNo;
        }
        public void SetCustomerName(string custno)
        {
            customerName = custno;
        }
        public string GetCustomerName()
        {
            return customerName;
        }
        static void Main(string[] args)
        {
            Account1 a = new Account1();
            Console.WriteLine("Enter Account No");
            long accn = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Account No "+ a.GetAccountNo());
            Console.WriteLine("Enter Customer Name");
            string custnm = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Customer Name " + a.GetCustomerName());

            Console.ReadLine();
        }
    }
}
