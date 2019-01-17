using Chapter06.Models;
using System;

namespace Chapter06.Commands
{
    class CeilingFanMediumCommand : IUndoableCommand
    {
        private readonly CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;

        public event EventHandler CanExecuteChanged;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Medium();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFanSpeed.High:
                    _ceilingFan.High();
                    break;
                case CeilingFanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;
                case CeilingFanSpeed.Low:
                    _ceilingFan.Low();
                    break;
                case CeilingFanSpeed.Off:
                    _ceilingFan.Off();
                    break;
                default:
                    break;
            }
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
