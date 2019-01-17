namespace SimpleCalculator.Receivers
{
    interface IReceiver
    {
        void SetAction(Action action);
        int GetResult();
    }
}
