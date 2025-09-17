using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class ContinueBTN : Form
    {
        public ContinueBTN()
        {
            InitializeComponent();
        }

        private void ctrlTrafficLight1_OnGreenLightOn(object sender, EventArgs e)
        {
            MessageBox.Show("Green Light ON!","Green",MessageBoxButtons.OK);
        }

        private void ctrlTrafficLight1_OnOrangeLightOn(object sender, EventArgs e)
        {
            MessageBox.Show("Orange Light ON!", "Orange", MessageBoxButtons.OK);
        }

        private void ctrlTrafficLight1_OnRedLightOn_1(object sender, EventArgs e)
        {
            MessageBox.Show("Red Light ON!", "Red", MessageBoxButtons.OK);
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            StartBTN.Enabled = false;
            button1.Enabled = false;
            StopBTN.Enabled = true;

            ctrlTrafficLight1.Reset();
            ctrlTrafficLight1.Start();
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            StopBTN.Enabled = false;
            button1.Enabled = true;
            StartBTN.Enabled = true;

            ctrlTrafficLight1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            StartBTN.Enabled = false;
            StopBTN.Enabled = true;

            ctrlTrafficLight1.Start();
        }
    }
}