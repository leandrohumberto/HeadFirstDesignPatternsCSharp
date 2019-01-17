namespace SimpleBank.Commands
{
    enum CommandState
    {
        Unprocessed,
        ExecuteFailed,
        ExecuteSucceeded,
        UndoFailed,
        UndoSucceeded,
    }
}
