using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Delegatess
{
    public class Account
    {
        public string AccountType { get; set; }
        public string LoanType { get; set; }
        public int LoanPrice { get; set; }
    }
    public class Customer
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }

        public List<Account> Accounts = new List<Account>();

    }
    class CustomerAccountGen
    {
        static void Main(string[] args)
        {
            List<Customer> cust = new List<Customer>();
            {
                new Customer {
                    AccountNo = 123455,
                    AccountName = "Priyanka",
                    Accounts ={new Account{AccountType="Saving",LoanType="car loan",LoanPrice=12443},
                                       new Account{AccountType="current",LoanType="car loan",LoanPrice=12643},
                                       new Account{AccountType="Saving",LoanType="home loan",LoanPrice=45443}
                                      }
                };
                new Customer
                {
                    AccountNo = 123455,
                    AccountName = "Priyanka",
                    Accounts ={new Account{AccountType="Saving",LoanType="car loan",LoanPrice=12443},
                                       new Account{AccountType="current",LoanType="car loan",LoanPrice=12643},
                                       new Account{AccountType="Saving",LoanType="home loan",LoanPrice=45443},
                                      }
                };
            };
            foreach (Customer c in cust)
            {
                Console.WriteLine(c.AccountNo + " " + c.AccountName+" ");
                foreach (Account e in c.Accounts)
                {
                    Console.WriteLine($"{e.AccountType}{e.LoanPrice}{e.LoanType}");
                }
            }

        }
    }
}
