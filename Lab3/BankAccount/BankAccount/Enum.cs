﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Csharpcourse
{

    public enum AccountType { Checking, Deposit }
    internal class BankAccount

    {

        public static void Main(string[] args)
        {


            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;



            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Typpe is {0}", platinumAccount);
        }


    }




} 