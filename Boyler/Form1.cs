using Boyler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boyler
{
    public partial class Form1 : Form
    {
        public Simulation Simulation { get; set; }
        private int TimeMultiplier = 1;
        public Form1()
        {
            InitializeComponent();
            Simulation = new Simulation();
        }

        private void showerTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Simulation.WaterAppliance.ShowerFlow = (double)showerTrackBar.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Simulation.Boiler.SetWaterFlow(Simulation.WaterAppliance);
            waterFlowLabel.Text = $"{Math.Round(Simulation.Boiler.WaterFlowPerMinute, 1)}l/min";
            Simulation.AddTime(timer.Interval*TimeMultiplier);
            simulationTimeLabel.Text = Simulation.Time.ToString();
            Simulation.CalculateHeating(timer.Interval*TimeMultiplier);
            boilerTempLabel.Text = $"{Simulation.Boiler.CurrentTemperature} Celsius";
        }

        private void showerTempTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Simulation.WaterAppliance.Shower = showerTempTrackBar.Value;
        }

        private void sinkTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Simulation.WaterAppliance.SinkFlow = (double)sinkTrackBar.Value;
        }

        private void sinkTempTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Simulation.WaterAppliance.Sink = sinkTempTrackBar.Value;
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                startSimulationButton.Text = "Spustit simulaci";
            }
            else
            {
                timer.Start();
                startSimulationButton.Text = "Zastavit simulaci";
            }
            
        }

        private void stateControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            heatControlCheckBox.Visible = stateControlCheckBox.Checked;
            if (heatControlCheckBox.Visible == false)
            {
                heatControlCheckBox.Checked = false;
            }
        }

        private void fastTimeButton_Click(object sender, EventArgs e)
        {
            TimeMultiplier = 10;
        }
    }
}
