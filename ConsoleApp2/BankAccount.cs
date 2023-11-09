using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        
        }
        //методы
        public double deposit(double x)
        {
            Balance += x; 
                return Balance;
        }
        public double Withdraw(double x)
        {
            if (Balance - x < 0)
            {
                Console.WriteLine("Вы должник !");
            }
            Balance -= x;
            if (Balance < 0)
            {
                Console.WriteLine("Вы должник !");
            }
            return Balance;
        }
        public void PrintBalance()
        {
            Console.WriteLine(Balance);
        }

    }
}
