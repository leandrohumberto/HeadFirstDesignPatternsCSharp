using System;

namespace Chapter06.Models
{
    class Light
    {
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} light's on!");
        }
        public void Off()
        {
            Console.WriteLine($"{_location} light's off!");
        }
    }
}
