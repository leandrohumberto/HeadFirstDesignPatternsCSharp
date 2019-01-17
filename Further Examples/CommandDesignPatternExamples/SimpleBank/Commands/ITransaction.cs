namespace SimpleBank.Commands
{
    interface ITransaction
    {
        int Id { get; }
        System.DateTime CreatedOn { get; }
        CommandState Status { get; }
        void Execute();
        void Undo();
    }
}
