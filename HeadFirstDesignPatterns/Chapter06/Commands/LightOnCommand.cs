using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class LightOnCommand : IUndoableCommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public event EventHandler CanExecuteChanged;

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
