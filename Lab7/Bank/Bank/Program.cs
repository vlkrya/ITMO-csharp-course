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
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
            {
                this.Deposit(amount);
            }
        }

        private void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        private bool Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Populate(decimal balance)

        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }

        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo;

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
            decimal balance = (decimal)3200.00;
            created.Populate(balance);
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

        private static void Main1()
        {
            BankAccount b1 = new BankAccount();
            b1.Populate(100);

            BankAccount b2 = new BankAccount();
            b2.Populate(100);

            Console.WriteLine("Before transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

            b1.TransferFrom(b2, 10);

            Console.WriteLine("After transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());
        }

    }

}