using System;

namespace Chapter07.HomeTheater
{
    class Amplifier
    {
        private Tuner _tuner;
        public Tuner Tuner
        {
            get { return _tuner; }
            set
            {
                Console.WriteLine("Top-O-Line Amplifier setting Tuner to Top-O-Line Tuner");
                _tuner = value;
            }
        }

        private CdPlayer _cdPlayer;
        public CdPlayer CdPlayer
        {
            get { return _cdPlayer; }
            set
            {
                Console.WriteLine("Top-O-Line Amplifier setting CD player to Top-O-Line CD Player");
                _cdPlayer = value;
            }
        }

        private DvdPlayer _dvdPlayer;
        public DvdPlayer DvdPlayer
        {
            get { return _dvdPlayer; }
            set
            {
                Console.WriteLine("Top-O-Line Amplifier setting DVD player to Top-O-Line DVD Player");
                _dvdPlayer = value;
            }
        }

        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Top-O-Line Amplifi er setting volume to {0}", value);
                _volume = value;
            }
        }


        public Amplifier(Tuner tuner = null, CdPlayer cdPlayer = null, DvdPlayer dvdPlayer = null)
        {
            Tuner = tuner;
            CdPlayer = cdPlayer;
            DvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Top-O-Line Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Amplifier off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Top-O-Line Amplifier surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line Amplifier stereo sound on (2 speakers)");
        }
    }
}
