using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class TvOnCommand : IUndoableCommand
    {
        private TV _tv;

        public event EventHandler CanExecuteChanged;

        public TvOnCommand(TV tv)
        {
            _tv = tv;
        }

        private void OnCanExecutedChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
