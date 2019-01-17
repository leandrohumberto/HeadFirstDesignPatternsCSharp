using System;

namespace Chapter06.Models
{
    class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} stereo is on!");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} stereo is off!");
        }

        public void SetDvd()
        {
            Console.WriteLine("DVD is set!");
        }

        public void SetCd()
        {
            Console.WriteLine("CD is set!");
        }

        public void SetRadio()
        {
            Console.WriteLine("Radio is set!");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume is set to {volume}!");
        }
    }
}
