using System;

namespace Chapter06.Models
{
    class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is open!");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is open!");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door was stopped!");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light is on!");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light is off!");
        }
    }
}
