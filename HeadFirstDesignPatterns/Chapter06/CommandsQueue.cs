using Chapter06.Commands;
using Chapter06.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chapter06
{
    class CommandsQueue
    {
        private List<IUndoableCommand> _commands;
        private int _runningThreads;
        private int _maxThereads;

        public CommandsQueue(IEnumerable<IUndoableCommand> commands, int maxTheads = 4)
        {
            _commands = new List<IUndoableCommand>(commands);
            _maxThereads = maxTheads;
            _runningThreads = 0;
        }

        public void ExecuteQueue()
        {
            while (_commands.Count > 0)
            {
                System.Threading.Thread.Sleep(1000);

                if (_runningThreads < _maxThereads)
                {
                    _runningThreads++;
                    var command = _commands[0];
                    _commands.Remove(command);

                    Task.Run(delegate
                    {
                        Console.WriteLine($"{command.GetType().Name} started.");
                        command.Execute(null);
                        System.Threading.Thread.Sleep(5000);
                        _runningThreads--;
                        Console.WriteLine($"{command.GetType().Name} finished.");
                    });
                }
            }
        }

        public static void RunTest()
        {
            var remoteControl = new RemoteControl();
            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo("Living Room");

            var commands = new List<IUndoableCommand>
            {
                new LightOnCommand(livingRoomLight),
                new LightOffCommand(livingRoomLight),
                new LightOnCommand(kitchenLight),
                new LightOffCommand(kitchenLight),
                new CeilingFanHighCommand(ceilingFan),
                new CeilingFanOffCommand(ceilingFan),
                new GarageDoorUpCommand(garageDoor),
                new GarageDoorDownCommand(garageDoor),
                new StereoOnWithCdCommand(stereo),
                new StereoOffCommand(stereo),
            };

            new CommandsQueue(commands, 2).ExecuteQueue();
            Console.ReadKey();
        }
    }
}
