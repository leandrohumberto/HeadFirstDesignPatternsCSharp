namespace DJSet.Controllers
{
    public interface IController
    {
        void Start();
        void Stop();
        void IncreaseBPM();
        void DecreaseBPM();
        void SetBPM(int bpm);
    }
}
