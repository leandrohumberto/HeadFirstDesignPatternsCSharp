using System;

namespace DJSet.Models
{
    public interface IHeartModel
    {
        int HeartRate { get; }
        event EventHandler<int> BpmChanged;
        event EventHandler BeatOccured;
    }
}
