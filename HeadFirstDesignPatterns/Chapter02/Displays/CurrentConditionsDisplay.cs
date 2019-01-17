using Chapter02.Models;
using Chapter02.Displays.Interfaces;
using System;

namespace Chapter02
{
    class CurrentConditionsDisplay : IObserver<WeatherMeasurement>, IElementDisplayer
    {
        private float _temperature;
        private float _humidity;
        private bool _available;
        private IDisposable _unsubcriber;

        public CurrentConditionsDisplay(IObservable<WeatherMeasurement> subject)
        {
            Subscribe(subject);
        }

        public string Info
        {
            get
            {
                if (_available)
                    return $"Current conditions: {_temperature}F degrees and {_humidity}% humidity.";

                return "Current conditions unavailable";
            }
        }

        public void OnNext(WeatherMeasurement value)
        {
            _temperature = value.Temperature;
            _humidity = value.Humidity;
            _available = true;
        }

        public void OnError(Exception error)
        {
            throw error;
        }

        public void OnCompleted()
        {
            _available = false;
        }

        public void Subscribe(IObservable<WeatherMeasurement> subject)
        {
            if (subject == null)
            {
                throw new ArgumentNullException();
            }

            _unsubcriber = subject.Subscribe(this);
            _available = true;
        }

        public void Unsubscribe()
        {
            _unsubcriber.Dispose();
            _available = false;
        }
    }
}
