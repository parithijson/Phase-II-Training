using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal class BankDetails
    {
        private int customerId;
        private string? name, status;
        private long accountNumber;
        private double balance;

        public BankDetails(int customerId,string? name, string? status, long accountNumber, double balance)
        {
            CustomerId = customerId;
            Name = name;
            Status = status;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string? Name { get => name; set => name = value; }
        public string? Status { get => status; set => status = value; }
        public long AccountNumber { get => accountNumber; set => accountNumber = value; }
        public double Balance { get => balance; set => balance = value; }
    
        public void FetchAccountDetails(int customerId)
        {
            if(CustomerId == customerId)
            {
                Console.WriteLine(AccountNumber + Name + Status + Balance);
            }
            else
            {
                Console.WriteLine("Sorry this Customer Id not found");
            }

        } public void FetchAccountDetails(long accountNumber)
        {
            if(AccountNumber == accountNumber)
            {
                Console.WriteLine(CustomerId + Name + Status + Balance);
            }
            else
            {
                Console.WriteLine("Sorry this Account Number not found");
            }

        }public void FetchAccountDetails(string name)
        {
            if(Name.Equals(name))
            {
                Console.WriteLine(CustomerId + AccountNumber + Status + Balance);
            }
            else
            {
                Console.WriteLine("Sorry this Name not found not found");
            }

        }
        
    
    
    }


}
