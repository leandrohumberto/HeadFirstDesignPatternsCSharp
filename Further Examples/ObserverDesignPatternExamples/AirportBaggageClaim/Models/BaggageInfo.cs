namespace AirportBaggageClaim.Models
{
    public class BaggageInfo
    {
        private int _flightNumber;

        public int FlightNumber
        {
            get { return _flightNumber; }
        }

        private string _from;

        public string From
        {
            get { return _from; }
        }

        private int _carousel;

        public int Carousel
        {
            get { return _carousel; }
        }

        internal BaggageInfo(int flight, string from, int carousel)
        {
            _flightNumber = flight;
            _from = from;
            _carousel = carousel;
        }
    }
}
