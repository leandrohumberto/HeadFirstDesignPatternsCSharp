namespace UserManagement.Commands
{
    interface ICommand
    {
        void Execute();
        ICommand ReverseCommand { get; }
    }
}
