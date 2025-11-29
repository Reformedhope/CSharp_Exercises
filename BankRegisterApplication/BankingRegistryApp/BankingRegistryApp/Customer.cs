using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingRegistryApp
{
    internal class Customer
    {
        //properties
        public string Name { get; set; }
        public int AccountNumber { get; }
        public decimal Balance { get; set; }

        //constructor
        public Customer(string name, int accNumber, decimal balance)
        {
            Name = name;
            AccountNumber = accNumber;
            Balance = balance;
        }

        //method for depositing into account
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        //method for withdrawing from account
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
