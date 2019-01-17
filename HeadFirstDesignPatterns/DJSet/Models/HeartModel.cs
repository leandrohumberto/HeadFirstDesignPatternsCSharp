using System;
using System.Threading;
using System.Threading.Tasks;

namespace DJSet.Models
{
    public class HeartModel : IHeartModel
    {
        private Random random = new Random();
        private int time = 1000;

        public HeartModel()
        {
            Task.Run(() => Run());
        }

        public int HeartRate => throw new NotImplementedException();

        public event EventHandler<int> BpmChanged;
        public event EventHandler BeatOccured;

        private void Run()
        {
            int lastrate = -1;

            for (; ; )
            {
                int change = random.Next(10);

                if (random.Next(2) == 0)
                {
                    change = 0 - change;
                }

                int rate = 60000 / (time + change);

                if (rate < 120 && rate > 50)
                {
                    time += change;
                    OnBeatOccured();

                    if (rate != lastrate)
                    {
                        lastrate = rate;
                        OnBpmChanged(rate);
                    }
                }

                try
                {
                    Thread.Sleep(time);
                }
                catch { }
            }
        }

        private void OnBpmChanged(int rate) => BpmChanged?.Invoke(this, rate);

        private void OnBeatOccured() => BeatOccured?.Invoke(this, EventArgs.Empty);
    }
}
