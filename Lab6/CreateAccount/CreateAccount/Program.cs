using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Csharpcourse
{
     public enum AccountType { Checking, Deposit }
     public class BankAccount

    {
        public void Populate(long number, decimal balance)

        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public String Type()
        {
            return accType.ToString();
        }
    }
    internal class CreateAccount
    {
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();
            Console.Write("Enter account number: ");
            long number = long.Parse(Console.ReadLine());
            decimal balance = (decimal)3200.00;
            created.Populate(number, balance);
            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
        public static void Main(string[] args)
        {
            BankAccount created = CreateAccount.NewBankAccount();
            Write(created);
        }

    }

}