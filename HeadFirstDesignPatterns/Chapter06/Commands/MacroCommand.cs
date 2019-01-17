using System;
using System.Collections.Generic;

namespace Chapter06.Commands
{
    class MacroCommand : IUndoableCommand
    {
        public event EventHandler CanExecuteChanged;

        private IEnumerable<IUndoableCommand> _commands;

        public MacroCommand(IEnumerable<IUndoableCommand> commands)
        {
            _commands = commands;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            foreach (var command in _commands)
            {
                command.Execute(null);
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }

        private void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
