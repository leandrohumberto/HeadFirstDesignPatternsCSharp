using System;
using SimpleBank.Receivers;

namespace SimpleBank.Commands
{
    class Deposit : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public int Id { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public CommandState Status { get; private set; }

        public Deposit(int id, Account account, decimal amount)
        {
            Id = id;
            CreatedOn = DateTime.UtcNow;
            _account = account;
            _amount = amount;
            Status = CommandState.Unprocessed;
        }

        public void Execute()
        {
            _account.Balance += _amount;
            Status = CommandState.ExecuteSucceeded;
        }

        public void Undo()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance += _amount;
                Status = CommandState.UndoSucceeded;
            }
            else
            {
                Status = CommandState.UndoFailed;
            }
        }
    }
}
