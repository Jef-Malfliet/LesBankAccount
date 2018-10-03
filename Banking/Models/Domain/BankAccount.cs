using System;
using System.Collections.Generic;

namespace Banking.Models.Domain
{
    public class BankAccount
    {
        #region Fields

        private decimal _balance;
        private ICollection<Transaction> _transactions;

        #endregion

        #region Properties

        public string AccountNumber { get; private set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }

        public IEnumerable<Transaction> Transactions { get { return _transactions; } }

        #endregion

        #region Constructors

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }

        #endregion

        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount,TransactionType.Deposit));
        }

        public virtual void Withdraw(decimal amount) //moet virtual zijn zodat gedrag in get en set kan worden overschreven
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }

        public override string ToString()
        {
            return $"{AccountNumber} -- {Balance}";
        }

        public override bool Equals(object obj)
        {
            BankAccount ba = obj as BankAccount; // as wordt gebruikt voor typecast te doen, werpt geen exception als het niet gaat, object wordt gewoon null
            if (ba == null)
            {
                return false;
            }
            return AccountNumber == ba.AccountNumber;
        }

        public override int GetHashCode()
        {
            return AccountNumber.GetHashCode();
        }

        #endregion
    }
}
