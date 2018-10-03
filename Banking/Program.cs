using Banking.Models.Domain;
using System;
using System.Collections.Generic;

namespace Banking
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Object initialization, enkel bij public setters. voor interactie tussen views en models
            //BankAccount anotherBa = new BankAccount()
            //{
            //    AccountNumber = "123-12312312-99",
            //    Balance = 200
            //};

            var myBA = new BankAccount("123-12312312-99", 50); // var want compiler kan zelf afleiden welk type myBA is

            Console.WriteLine($"Accountnumber is {myBA.AccountNumber}");
            Console.WriteLine(myBA);
            myBA.Deposit(200);
            Console.WriteLine(myBA);
            myBA.Withdraw(50);
            Console.WriteLine(myBA);

            foreach (var item in myBA.Transactions)
            {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }

            BankAccount mySA = new SavingsAccount("123-12312312-67", 0.01M);
            mySA.Deposit(1000);
            ((SavingsAccount) mySA).addInterest();
            mySA.Withdraw(10);
            Console.WriteLine($"Balance of savingsAccount: {mySA.Balance}");
            foreach (var item in mySA.Transactions)
            {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }
            Console.ReadKey();
        }
    }
}
