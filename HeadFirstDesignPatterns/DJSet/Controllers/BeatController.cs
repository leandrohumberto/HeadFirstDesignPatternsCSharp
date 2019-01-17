using DJSet.Models;
using DJSet.Views;

namespace DJSet.Controllers
{
    public class BeatController : IController
    {
        private IBeatModel model;
        private IDJView view;

        public BeatController(IDJView view, IBeatModel model)
        {
            this.model = model;
            this.view = view;
            view.DisableStopMenuItem();
            view.EnableStartMenuItem();
            model.Initialize();
        }

        public void DecreaseBPM()
        {
            model.BPM--;
        }

        public void IncreaseBPM()
        {
            model.BPM++;
        }

        public void SetBPM(int bpm)
        {
            model.BPM = bpm;
        }

        public void Start()
        {
            model.On();
            view.DisableStartMenuItem();
            view.EnableStopMenuItem();
        }

        public void Stop()
        {
            model.Off();
            view.EnableStartMenuItem();
            view.DisableStopMenuItem();
        }
    }
}
