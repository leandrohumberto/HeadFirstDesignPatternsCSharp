using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class TvOffCommand : IUndoableCommand
    {
        private TV _tv;

        public event EventHandler CanExecuteChanged;

        public TvOffCommand(TV tv)
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
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
