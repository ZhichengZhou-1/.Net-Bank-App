using System;
using System.Collections.Generic;
using BankyStuff;
//using Humanizer;


namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("car".Pluralize());
            //Console.WriteLine(123.ToWords());
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());


        }
    }
}

