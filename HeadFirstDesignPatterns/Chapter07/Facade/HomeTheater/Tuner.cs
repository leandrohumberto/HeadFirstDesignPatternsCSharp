using System;

namespace Chapter07.HomeTheater
{
    class Tuner
    {
        public void On()
        {
            Console.WriteLine("Top-O-Line Tuner is on");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Tuner is off");
        }

        public void SetAM()
        {
            Console.WriteLine("Top-O-Line Tuner set to AM");
        }

        public void SetFM()
        {
            Console.WriteLine("Top-O-Line Tuner set to FM");
        }

        public void SetFrequency(double frequency)
        {
            if (frequency < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("Top-O-Line Tuner frequency set to {0}", frequency);
        }
    }
}
