using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    class BankAccount
    {
        private readonly long accountNumber;
        private string accountHolderName;
        private int _balance;

        public BankAccount(long accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = 0;
            
        }

        public string AccountHolderName { get => accountHolderName; set => accountHolderName = value; }
        public int Balance { get => _balance; set => _balance = value; }

        public void Deposit(int amount)
        {
           Balance += amount;
           
        }
        public int WithDraw(int amount)
        {
            if (Balance >= amount) {
                Balance -= amount;
                return 1;
               
            }
            else if(Balance < amount) { }
            {
                return 0;
            }
        }
        public void AccountDetails()
        {
            Console.WriteLine("Your Account Details");
            Console.WriteLine("____________________");
            Console.WriteLine();
            Console.WriteLine($"Account Holder Name:{accountHolderName} ");
            Console.WriteLine($"Account Number: {accountNumber} ");
            Console.WriteLine($"Your balance: {Balance} ");
        }

    }
}
