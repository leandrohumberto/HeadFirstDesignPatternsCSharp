using System;
using SimpleBank.Receivers;

namespace SimpleBank.Commands
{
    class Withdraw : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public int Id { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public CommandState Status { get; private set; }

        public Withdraw(int id, Account account, decimal amount)
        {
            Id = id;
            CreatedOn = DateTime.UtcNow;
            _account = account;
            _amount = amount;
            Status = CommandState.Unprocessed;
        }

        public void Execute()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;
                Status = CommandState.ExecuteSucceeded;
            }
            else
            {
                Status = CommandState.ExecuteFailed;
            }
        }

        public void Undo()
        {
            _account.Balance += _amount;
            Status = CommandState.UndoSucceeded;
        }
    }
}
