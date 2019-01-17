using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class LightOffCommand : IUndoableCommand
    {
        private readonly Light _light;

        public event EventHandler CanExecuteChanged;

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
