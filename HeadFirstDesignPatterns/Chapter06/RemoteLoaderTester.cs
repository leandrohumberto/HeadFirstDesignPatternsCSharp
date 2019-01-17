using Chapter06.Commands;
using Chapter06.Models;
using System;

namespace Chapter06
{
    static class RemoteLoaderTester
    {
        public static void UndoTest()
        {
            var remoteControl = new RemoteControl();
            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo("Living Room");
            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);
            var ceilingFanOn = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);
            var stereoOnWithCD = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(4, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            Console.ReadKey();
        }

        public static void CeilingFanTest()
        {
            var remoteControl = new RemoteControl();
            var ceilingFan = new CeilingFan("Living Room");
            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(1, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine(remoteControl);

            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(2);

            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            Console.ReadKey();
        }

        public static void MacroCommandTests()
        {
            var light = new Light("Living Room");
            var tv = new TV("Living Room");
            var stereo = new Stereo("Living Room");
            var hottub = new Hottub();

            var lightOn = new LightOnCommand(light);
            var stereoOn = new StereoOnWithCdCommand(stereo);
            var tvOn = new TvOnCommand(tv);
            var hottubOn = new HottubOnCommand(hottub);

            var lightOff = new LightOffCommand(light);
            var stereoOff = new StereoOffCommand(stereo);
            var tvOff = new TvOffCommand(tv);
            var hottubOff = new HottubOffCommand(hottub);

            IUndoableCommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            IUndoableCommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };
            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            var remoteControl = new RemoteControl();
            remoteControl.SetCommand(1, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("---Pushing Macro On-- -");
            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine("---Pushing Macro Off-- -");
            remoteControl.OffButtonWasPushed(1);

            Console.ReadKey();
        }
    }
}
