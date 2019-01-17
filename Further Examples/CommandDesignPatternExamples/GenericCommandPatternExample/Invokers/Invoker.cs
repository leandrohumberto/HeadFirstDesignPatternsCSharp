using GenericCommandPatternExample.Commands;

namespace GenericCommandPatternExample.Invokers
{
    /// <summary>
    /// Asks the command to carry out the request. 
    /// Decides when the method should be called.
    /// </summary>
    class Invoker
    {
        private Command _commandObject;

        public void SetCommand(Command commandObject)
        {
            _commandObject = commandObject;
        }

        public void ExecuteCommand()
        {
            _commandObject.Execute();
        }
    }
}
