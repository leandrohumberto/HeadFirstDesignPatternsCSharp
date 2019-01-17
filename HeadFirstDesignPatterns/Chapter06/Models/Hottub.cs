using System;

namespace Chapter06.Models
{
    class Hottub
    {
        private float _temperature = 70;

        public Hottub() { }

        public Hottub(float temperature) : this()
        {
            _temperature = temperature;
        }

        public void On()
        {
            Console.WriteLine($"Hot tub is on at {_temperature}°F!");
        }

        public void Off()
        {
            Console.WriteLine("Hot tub is off!");
        }

        public void Circulate()
        {
            Console.WriteLine("Hot tub water is circulating!");
        }

        public void JetsOn()
        {
            Console.WriteLine("Hot tub jets are on!");
        }

        public void JetsOff()
        {
            Console.WriteLine("Hot tub jets are off!");
        }
        
        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"Hot tub temperature is set to {_temperature}°F!");
        }
    }
}
