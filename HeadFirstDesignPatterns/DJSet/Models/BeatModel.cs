using System;
using System.Collections.Generic;
using System.Timers;

namespace DJSet.Models
{
    public class BeatModel : IBeatModel
    {
        private int _bpm = 1;
        private Lazy<Timer> _lazy = new Lazy<Timer>(() => new Timer());
        private Timer _timer => _lazy.Value;

        public event EventHandler<int> BpmChanged;
        public event EventHandler BeatOccured;

        public int BPM
        {
            get { return _bpm; }
            set
            {
                if (!EqualityComparer<int>.Default.Equals(_bpm, value) && value > 0)
                {
                    _bpm = value;
                    OnBPMChanged();
                }
            }
        }

        public void Initialize()
        {
            _timer.Interval = 60000 / BPM;
            _timer.Elapsed += delegate { OnBeatOccured(); };
        }

        public void Off()
        {
            _timer.Stop();
        }

        public void On()
        {
            OnBeatOccured();
            _timer.Start();
        }

        private void OnBPMChanged()
        {
            _timer.Interval = 60000 / BPM;
            BpmChanged?.Invoke(this, BPM);
        }

        private void OnBeatOccured() => BeatOccured?.Invoke(this, EventArgs.Empty);
    }
}
