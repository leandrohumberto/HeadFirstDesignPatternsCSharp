using System;
using SimpleBank.Receivers;

namespace SimpleBank.Commands
{
    class Transfer : ITransaction
    {
        private readonly Account _fromAccount;
        private readonly Account _toAccount;
        private readonly decimal _amount;

        public int Id { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public CommandState Status { get; private set; }

        public Transfer(int id, Account fromAccount, Account toAccount, decimal amount)
        {
            Id = id;
            CreatedOn = DateTime.UtcNow;
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            Status = CommandState.Unprocessed;
        }

        public void Execute()
        {
            if (_fromAccount.Balance >= _amount)
            {
                _fromAccount.Balance -= _amount;
                _toAccount.Balance += _amount;
                Status = CommandState.ExecuteSucceeded;
            }
            else
            {
                Status = CommandState.ExecuteFailed;
            }
        }

        public void Undo()
        {
            if (_toAccount.Balance >= _amount)
            {
                _toAccount.Balance -= _amount;
                _fromAccount.Balance += _amount;
                Status = CommandState.UndoSucceeded;
            }
            else
            {
                Status = CommandState.UndoFailed;
            }
        }
    }
}
