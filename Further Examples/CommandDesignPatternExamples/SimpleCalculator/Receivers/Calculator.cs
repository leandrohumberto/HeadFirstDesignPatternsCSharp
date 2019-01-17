namespace SimpleCalculator.Receivers
{
    class Calculator : IReceiver
    {
        private int _x;
        private int _y;
        private Action _currentAction;

        public Calculator(int x, int y)
        {
            _x = x;
            _y = y;
        }

        #region IReciever members
        public void SetAction(Action action)
        {
            _currentAction = action;
        }

        public int GetResult()
        {
            int result = 0;

            switch (_currentAction)
            {
                case Action.Add:
                    result = _x + _y;
                    break;
                case Action.Subtract:
                    result = _x - _y;
                    break;
                case Action.Multiply:
                    result = _x * _y;
                    break;
                default:
                    break;
            }

            return result;
        }
        #endregion
    }
}
