using SimpleBank.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBank.Invokers
{
    class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get
            {
                return _transactions.Any(t => 
                t.Status == CommandState.Unprocessed || 
                t.Status == CommandState.ExecuteFailed || 
                t.Status == CommandState.UndoFailed);
            }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            var pendingExecutions = _transactions.Where(t => t.Status == CommandState.Unprocessed ||
                t.Status == CommandState.ExecuteFailed);

            // Execute transactions that are unprocessed, or had a previous Execute fail.
            foreach (var transaction in pendingExecutions)
            {
                transaction.Execute();
            }

            var pendingUndos = _transactions.Where(t => t.Status == CommandState.UndoFailed);

            // Retry the Undo, for transactions that had a previous Undo fail.
            foreach (var transaction in pendingUndos)
            {
                transaction.Undo();
            }
        }

        public void UndoTransactionNumber(int id)
        {
            // Get the Command object that has the passed ID.
            // If it does not exist in _transactions, the result will be null (default, for this object type).
            var transaction = _transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                throw new ArgumentException($"There is no transaction number {id}.");
            }

            if (transaction.Status != CommandState.ExecuteSucceeded)
            {
                throw new ArgumentException("Can only undo transactions that have been successfully executed.");
            }

            // We have a valid transaction, so perform the "undo".
            transaction.Undo();

            // Remove the transaction, if it was successfully completed.
            if (transaction.Status == CommandState.UndoSucceeded)
            {
                _transactions.Remove(transaction);
            }
        }

        public void RemoveOldTransactions()
        {
            // Remove transaction that have been Executed, and are more than 15 days old.
            _transactions.RemoveAll(t =>
                t.Status == CommandState.ExecuteSucceeded &&
                (DateTime.UtcNow - t.CreatedOn).Days > 15);
        }
    }
}
