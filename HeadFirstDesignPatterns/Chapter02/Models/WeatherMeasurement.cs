namespace Chapter02.Models
{
    class WeatherMeasurement
    {
        private float _temperature;

        public float Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        private float _humidity;

        public float Humidity
        {
            get { return _humidity; }
            set { _humidity = value; }
        }

        private float _pressure;

        public float Pressure
        {
            get { return _pressure; }
            set { _pressure = value; }
        }
    }
}
