using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class GarageDoorDownCommand : IUndoableCommand
    {
        private readonly GarageDoor _garageDoor;

        public event EventHandler CanExecuteChanged;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
