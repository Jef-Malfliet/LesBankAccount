using Banking.Models.Domain;
using System;

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

            BankAccount myBA = new BankAccount("123-12312312-99", 50);
            Console.WriteLine($"Accountnumber is {myBA.AccountNumber}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            Console.ReadKey();
        }
    }
}
