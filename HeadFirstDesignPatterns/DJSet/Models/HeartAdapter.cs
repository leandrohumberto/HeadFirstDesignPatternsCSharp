using System;

namespace DJSet.Models
{
    public class HeartAdapter : IBeatModel
    {
        private IHeartModel _heart;

        public HeartAdapter(IHeartModel heart)
        {
            _heart = heart;
            _heart.BeatOccured += OnBeatOccured;
            _heart.BpmChanged += OnBpmChanged;
        }

        public int BPM
        {
            get { return _heart.HeartRate; }
            set {  }
        }

        public event EventHandler<int> BpmChanged;
        public event EventHandler BeatOccured;

        public void Initialize() { }

        public void On() { }

        public void Off() { }

        private void OnBpmChanged(object sender, int e) => BpmChanged?.Invoke(this, e);

        private void OnBeatOccured(object sender, EventArgs e) => BeatOccured?.Invoke(this, e);
    }
}
