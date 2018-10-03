using System;

namespace Banking.Models.Domain
{
    public class Transaction
    {
        #region Properties
        public decimal Amount { get; }
        public TransactionType TransactionType { get; }
        public DateTime DateOfTransaction { get; } //DateTime wordt opgeslagen op de threadstack => immutable, zoals string bij verandering van waarde wordt nieuwe gemaakt
        public bool IsDeposit { get { return TransactionType == TransactionType.Deposit;  } }
        public bool IsWithdraw { get { return TransactionType == TransactionType.Withdraw;  } }

        #endregion

        #region Contructors
        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTransaction = DateTime.Now;
        }

        #endregion


    }
}
