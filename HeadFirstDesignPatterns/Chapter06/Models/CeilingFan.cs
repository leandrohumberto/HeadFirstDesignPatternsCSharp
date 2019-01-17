using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06.Models
{
    class CeilingFan
    {
        private readonly string _location;
        private CeilingFanSpeed _speed;

        public CeilingFanSpeed Speed { get { return _speed; } }

        public CeilingFan(string location)
        {
            _speed = CeilingFanSpeed.Off;
            _location = location;
        }

        public void High()
        {
            _speed = CeilingFanSpeed.High;
            Console.WriteLine($"{_location} ceiling fan is high!");
        }

        public void Medium()
        {
            _speed = CeilingFanSpeed.Medium;
            Console.WriteLine($"{_location} ceiling fan is medium!");
        }

        public void Low()
        {
            _speed = CeilingFanSpeed.Low;
            Console.WriteLine($"{_location} ceiling fan is low!");
        }

        public void Off()
        {
            _speed = CeilingFanSpeed.Off;
            Console.WriteLine($"{_location} ceiling fan is off!");
        }
    }
}
