using System;
namespace Chapter07.HomeTheater
{
    class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Top-O-Line Tuner is on");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Tuner is off");
        }

        public void Dim(int percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("Theater Ceiling Lights dimming to {0}%", percentage);
        }
    }
}
