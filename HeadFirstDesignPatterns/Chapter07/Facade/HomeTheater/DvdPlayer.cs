using System;

namespace Chapter07.HomeTheater
{
    class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("Top-O-Line DVD Player on");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line DVD Player off");
        }

        public void Eject()
        {
            Console.WriteLine("Top-O-Line DVD Player eject");
        }

        public void Pause()
        {
            Console.WriteLine("Top-O-Line DVD Player pause");
        }

        public void Play()
        {
            Console.WriteLine("Top-O-Line DVD Player play");
        }
        
        public void Play(string video)
        {
            if (string.IsNullOrWhiteSpace(video))
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine("Top-O-Line DVD Player play {0}", video);
        }

        public void Stop()
        {
            Console.WriteLine("Top-O-Line DVD Player stop");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line DVD Player surround sound");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Top-O-Line DVD Player two channel audio");
        }
    }
}
