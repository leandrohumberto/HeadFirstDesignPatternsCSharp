namespace Chapter06.Commands
{
    interface IUndoableCommand : System.Windows.Input.ICommand
    {
        void Undo();
    }
}
