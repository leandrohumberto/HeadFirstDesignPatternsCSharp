using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class GarageDoorUpCommand : IUndoableCommand
    {
        private GarageDoor _garageDoor;

        public event EventHandler CanExecuteChanged;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        private void OnCanExecutedChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
