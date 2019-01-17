using System;
using System.Collections.Generic;
using UserManagement.Commands;

namespace UserManagement.Invokers
{
    class CommandInvoker
    {
        private SynchronizedCollection<ICommand> _commands = new SynchronizedCollection<ICommand>();
        private Queue<ICommand> _executedCommands;

        /// <summary>
        /// Call this method to add a new command to the list of in-memory commands
        /// </summary>
        /// <param name="command">The command to be added to the invoker.</param>
        public void AddCommand(ICommand command)
        {
            // Add commands and get them ready for execution
            _commands.Add(command);
        }

        /// <summary>
        /// Execute all the in-memory commands.
        /// </summary>
        public void Execute()
        {
            // Perform a double-check lock
            if (_commands.Count > 0)
            {
                lock (_commands.SyncRoot)
                {
                    if (_commands.Count > 0)
                    {
                        _executedCommands = new Queue<ICommand>();

                        foreach (var command in _commands)
                        {
                            try
                            {
                                command.Execute();
                                var rc = command.ReverseCommand;

                                if (rc != null)
                                {
                                    _executedCommands.Enqueue(rc);
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($@"Exception = {ex.Message}\r\nCommand = {
                                    command.ToString()}");
                                throw;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Revert back all the successfully executed commands
        /// </summary>
        public void RevertExecutions()
        {
            if (_executedCommands != null && _executedCommands.Count > 0)
            {
                lock (_commands.SyncRoot)
                {
                    while (_executedCommands.Count > 0)
                    {
                        _executedCommands.Dequeue().Execute();
                    }
                }
            }
        }
    }
}
