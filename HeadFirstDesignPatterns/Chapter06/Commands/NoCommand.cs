using System;

namespace Chapter06.Commands
{
    class NoCommand : IUndoableCommand
    {
        public event EventHandler CanExecuteChanged;

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object parameter)
        {
            return false;
        }

        public void Execute(object parameter)
        {
            
        }

        public void Undo()
        {
            
        }
    }
}
