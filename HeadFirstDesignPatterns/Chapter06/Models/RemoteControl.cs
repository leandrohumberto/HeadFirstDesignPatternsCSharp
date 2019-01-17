using Chapter06.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter06.Models
{
    class RemoteControl
    {
        private readonly List<IUndoableCommand> _onCommands = new List<IUndoableCommand>();
        private readonly List<IUndoableCommand> _offCommands = new List<IUndoableCommand>();
        private IUndoableCommand undoCommand;
        private readonly int _numberOfSlots = 7;
        private readonly IUndoableCommand NO_COMMAND = new NoCommand();

        public RemoteControl()
        {
            InitializeSlots();
        }

        public RemoteControl(int numberOfSlots)
        {
            _numberOfSlots = numberOfSlots;
            InitializeSlots();
        }

        public void SetCommand(int slot, IUndoableCommand onCommand, IUndoableCommand offCommand)
        {
            ValidateSlot(slot);
            _onCommands[slot - 1] = onCommand == null ? NO_COMMAND : onCommand;
            _offCommands[slot - 1] = offCommand == null ? NO_COMMAND : offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            ValidateSlot(slot);
            _onCommands[slot - 1].Execute(null);
            undoCommand = _onCommands[slot - 1];
        }

        public void OffButtonWasPushed(int slot)
        {
            ValidateSlot(slot);
            _offCommands[slot - 1].Execute(null);
            undoCommand = _offCommands[slot - 1];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control------ -\n");

            for (int i = 0; i < _onCommands.Count; i++)
            {
                stringBuilder.Append($"[slot {i + 1}] {_onCommands[i].GetType().Name}\t{_offCommands[i].GetType().Name} \n");
            }

            stringBuilder.Append($"[undo] {undoCommand.GetType().Name}\n");

            return stringBuilder.ToString();
        }

        private void InitializeSlots()
        {
            var noCommand = NO_COMMAND;

            for (int i = 0; i < _numberOfSlots; i++)
            {
                _onCommands.Add(noCommand);
                _offCommands.Add(noCommand);
            }

            undoCommand = NO_COMMAND;
        }

        private void ValidateSlot(int slot)
        {
            if (slot < 1 || slot > _numberOfSlots + 1)
            {
                throw new ArgumentOutOfRangeException($"Slot number {slot} is invalid.");
            }
        }
    }
}
