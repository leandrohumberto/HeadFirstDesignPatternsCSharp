using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class StereoOffCommand : IUndoableCommand
    {
        private readonly Stereo _stereo;

        public event EventHandler CanExecuteChanged;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
