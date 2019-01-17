using Chapter02.Models;
using System;
using System.Collections.Generic;

namespace Chapter02.Services
{
    class WeatherData : IObservable<WeatherMeasurement>
    {
        private List<IObserver<WeatherMeasurement>> _observers;

        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherMeasurement>>();
        }

        public float Temperature
        {
            get { return _temperature; }
            set { SetProperty(ref _temperature, value); }
        }        

        public float Humidity
        {
            get { return _humidity; }
            set { SetProperty(ref _humidity, value); }
        }        

        public float Pressure
        {
            get { return _pressure; }
            set { SetProperty(ref _pressure, value); }
        }

        public IDisposable Subscribe(IObserver<WeatherMeasurement> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber<WeatherMeasurement>(_observers, observer);            
        }

        public void UpdateMeasurements(WeatherMeasurement measurement)
        {
            SetProperty(ref _temperature, measurement.Temperature);
            SetProperty(ref _humidity, measurement.Humidity);
            SetProperty(ref _pressure, measurement.Pressure);
        }

        public void FinishMeasurement()
        {
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }
        }

        private void OnMeasurementsChanged()
        {
            WeatherMeasurement measurement = CreateMeasumentData();

            foreach (var observer in _observers)
            {
                observer.OnNext(measurement);
            }
        }

        private WeatherMeasurement CreateMeasumentData()
        {
            return new WeatherMeasurement()
            {
                Temperature = _temperature,
                Humidity = _humidity,
                Pressure = _pressure,
            };
        }

        private void SetProperty<T>(ref T property, T value)
        {
            if (!EqualityComparer<T>.Default.Equals(property, value))
            {
                property = value;
                OnMeasurementsChanged();
            }
        }
    }
}
