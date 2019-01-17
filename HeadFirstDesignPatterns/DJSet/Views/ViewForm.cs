using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJSet.Views
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        public void OnBpmChanged(object sender, int bpm)
        {
            MethodInvoker invoker = delegate { statusLabel.Text = bpm.ToString(); };
            Invoke(invoker);
        }

        public void OnBeatOccured(object sender, EventArgs e)
        {
            MethodInvoker invoker = delegate
            {
                if (progressBar.Value == progressBar.Maximum)
                    progressBar.Value = progressBar.Minimum;
                else
                    progressBar.Value = progressBar.Maximum;
            };

            Invoke(invoker);
        }
    }
}
