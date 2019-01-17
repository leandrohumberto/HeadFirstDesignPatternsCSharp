using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class HottubOffCommand : IUndoableCommand
    {
        private readonly Hottub _hottub;

        public event EventHandler CanExecuteChanged;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _hottub.Off();
        }

        public void Undo()
        {
            _hottub.On();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
