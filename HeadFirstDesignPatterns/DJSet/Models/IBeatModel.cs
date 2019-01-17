using System;

namespace DJSet.Models
{
    public interface IBeatModel
    {
        int BPM { get; set; }
        event EventHandler<int> BpmChanged;
        event EventHandler BeatOccured;
        void Initialize();
        void On();
        void Off();
    }
}
