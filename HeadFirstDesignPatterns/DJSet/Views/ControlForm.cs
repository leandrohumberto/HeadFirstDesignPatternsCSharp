using DJSet.Controllers;
using DJSet.Models;
using System;
using System.Windows.Forms;

namespace DJSet.Views
{
    public partial class ControlForm : Form, IDJView
    {
        private IBeatModel model;
        private IController controller;
        private ViewForm viewForm;

        public ControlForm()
        {
            InitializeComponent();
            var heartModel = new HeartModel();
            model = new HeartAdapter(heartModel);
            controller = new HeartController(this, heartModel);
            viewForm = new ViewForm();
            viewForm.AddOwnedForm(this);
            FormClosed += delegate { Application.Exit(); };
            viewForm.Show();
            model.BeatOccured += OnBeatOccured;
            model.BpmChanged += OnBpmChanged;
            //Anchor = AnchorStyles.Bottom;
        }

        private void OnBpmChanged(object sender, int e)
        {
            viewForm.OnBpmChanged(this, e);
        }

        private void OnBeatOccured(object sender, EventArgs e)
        {
            viewForm.OnBeatOccured(this, e);
        }

        private void startOptionMenuDJControl_Click(object sender, EventArgs e)
        {
            controller.Start();
        }

        private void stopOptionMenuDJControl_Click(object sender, EventArgs e)
        {
            controller.Stop();
        }

        private void quitOptionMenuDJControl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericBPM_ValueChanged(object sender, EventArgs e)
        {
            controller.SetBPM(Convert.ToInt32(Math.Round(numericBPM.Value)));
        }

        private void btnSetBPM_Click(object sender, EventArgs e)
        {
            controller.SetBPM(Convert.ToInt32(Math.Round(numericBPM.Value)));
        }

        public void EnableStopMenuItem()
        {
            stopOptionMenuDJControl.Enabled = true;
        }

        public void DisableStopMenuItem()
        {
            stopOptionMenuDJControl.Enabled = false;
        }

        public void EnableStartMenuItem()
        {
            startOptionMenuDJControl.Enabled = true;
        }

        public void DisableStartMenuItem()
        {
            startOptionMenuDJControl.Enabled = false;
        }
    }
}
