using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Delegatess
{
    public delegate void Delegate2();
    public class Bank
    {
        public event Delegate2 BankEvent;
        public event Delegate2 Zerobal;
        public event Delegate2 lessbal;

        public int balance;
        
        public Bank()
        {
            balance = 8000;
        }
        public void Withdraw(int dbtamt)
        {
            if (dbtamt > balance)
            {
                BankEvent();
                Console.WriteLine($"Your Balance is {balance}");
            }
            else if(balance==dbtamt-balance)
            {
                Zerobal();
                Console.WriteLine($"Your balance is {balance}");
            }
        }
    }
    class BankEvent
    {

        static void lessbal()
        {
            Console.WriteLine("Your balance is less than dbt amt");
        }
        static void zerobal()
        {
            Console.WriteLine("Your balance is Zero");
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.BankEvent += new Delegate2(lessbal);
            b.Zerobal += new Delegate2(zerobal);
            b.Withdraw(7000);

        }
    }

}



