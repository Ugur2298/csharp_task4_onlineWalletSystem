using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_fourth_task__online_Wallet_System_
{
    internal class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime OperationTime { get; set; }
        public TransactionType TypeTransaction { get; set; }
        public OperationType TypeOperation { get; set; }
        public string Description { get; set; }

        public Transaction(decimal Amount, DateTime OperationTime, TransactionType TypeTransaction, OperationType TypeOperation, string Description)
        {
            this.Amount = Amount;
            this.OperationTime = OperationTime;
            this.TypeTransaction = TypeTransaction;
            this.TypeOperation = TypeOperation;
            this.Description = Description;
        }
    }
}
