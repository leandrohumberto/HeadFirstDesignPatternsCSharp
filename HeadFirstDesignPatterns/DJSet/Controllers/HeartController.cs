using DJSet.Models;
using DJSet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJSet.Controllers
{
    public class HeartController : IController
    {
        private IDJView view;
        private IHeartModel model;

        public HeartController(IDJView view, IHeartModel model)
        {
            this.view = view;
            this.model = model;
            view.DisableStartMenuItem();
            view.DisableStartMenuItem();
        }

        public void DecreaseBPM() { }

        public void IncreaseBPM() { }

        public void SetBPM(int bpm) { }

        public void Start() { }

        public void Stop() { }
    }
}
