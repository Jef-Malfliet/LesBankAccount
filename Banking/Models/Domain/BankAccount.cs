using System;

namespace Banking.Models.Domain
{
    public class BankAccount
    {
        //private string _accountNumber;
        #region Fields
        private decimal _balance;
        #endregion

        #region Properties
        public string AccountNumber { get; private set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }

        public BankAccount()
        {
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
