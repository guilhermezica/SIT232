using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        //Instance variables
        String name;
        decimal balance;

        // Accessor Methods
        public Account(String name, decimal balance)
        {
            this.balance = balance;
            this.name = name;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
        }

        public void Print()
        {
            Console.WriteLine(this.name + "'s balance is: $" + this.balance + " dollars");
        }

        public String Name()
        {
            return this.name;
        }
    }
}
