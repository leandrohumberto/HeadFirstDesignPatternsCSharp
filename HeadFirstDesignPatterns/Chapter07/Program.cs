using Chapter07.HomeTheater;
using System;

namespace Chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            var amp = new Amplifier();
            var tuner = new Tuner();
            var dvd = new DvdPlayer();
            var cd = new CdPlayer();
            var projector = new Projector();
            var screen = new Screen();
            var lights = new TheaterLights();
            var popper = new PopcornPopper();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);
            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();

            Console.ReadKey();
        }
    }
}
