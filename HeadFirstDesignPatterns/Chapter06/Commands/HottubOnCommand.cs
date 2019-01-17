using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class HottubOnCommand : IUndoableCommand
    {
        private readonly Hottub _hottub;

        public event EventHandler CanExecuteChanged;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _hottub.On();
        }

        public void Undo()
        {
            _hottub.Off();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
