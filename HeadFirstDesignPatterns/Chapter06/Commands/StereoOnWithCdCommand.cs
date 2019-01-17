using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class StereoOnWithCdCommand : IUndoableCommand
    {
        private readonly Stereo _stereo;

        public event EventHandler CanExecuteChanged;

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
