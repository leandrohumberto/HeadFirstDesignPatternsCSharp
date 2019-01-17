using System.Windows.Input;

namespace Chapter06.Models
{
    class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonPressed()
        {
            _slot.Execute(null);
        }
    }
}
