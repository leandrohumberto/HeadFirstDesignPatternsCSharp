using System;

namespace Chapter06.Models
{
    class TV
    {
        private int _channel;
        private int _volume;
        private string _location;

        public TV(string location)
        {
            _location = location;
        }

        public TV(string location, int channel, int volume) : this(location)
        {
            _channel = channel;
            _volume = volume;
        }

        public void On()
        {
            Console.WriteLine($"{_location} TV is on!");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} TV is off!");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"{_location}'s TV volume is set to {_volume}!");
        }

        public void SetInputChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine($"{_location}'s TV channel is set to {_channel}!");
        }
    }
}
