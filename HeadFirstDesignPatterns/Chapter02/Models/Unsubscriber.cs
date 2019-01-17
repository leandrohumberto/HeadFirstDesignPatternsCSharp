using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02.Models
{
    class Unsubscriber<WeatherMeasurement> : IDisposable
    {
        private List<IObserver<WeatherMeasurement>> _observers;
        private IObserver<WeatherMeasurement> _observer;

        public Unsubscriber(IEnumerable<IObserver<WeatherMeasurement>> observers, IObserver<WeatherMeasurement> observer)
        {
            _observers = new List<IObserver<WeatherMeasurement>>(observers);
            _observer = observer;
        }

        public void Dispose()
        {
            _observers.Remove(_observer);
        }
    }
}
