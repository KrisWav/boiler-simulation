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
        public Form1()
        {
            InitializeComponent();
            Simulation = new Simulation();
            timeMultiplierTrackBar.Value = 1;
        }

        private void showerTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Simulation.WaterAppliance.ShowerFlow = (double)showerTrackBar.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Simulation.CalculateSimulationParameters(timer.Interval);

            if (Simulation.PowerOff)
            {
                heatControlCheckBox.Enabled = false;
                heatControlCheckBox.Checked = false;
            }
            else heatControlCheckBox.Enabled = true;

            waterFlowLabel.Text = $"{Math.Round(Simulation.Boiler.WaterFlowPerMinute, 1)}l/min";
            waterConsumptionLabel.Text = $"{Math.Round(Simulation.ConsumedWater, 1)}l";
            simulationTimeLabel.Text = Simulation.Time.ToString(@"hh\:mm\:ss");
            energyConsumptionLabel.Text = $"{Math.Round(Simulation.EnergyConsumption, 1)}Wh";
            boilerTempLabel.Text = $"{Math.Round(Simulation.Boiler.CurrentTemperature, 2)}°C";


            if (Simulation.Boiler.Heating)
            {
                spiralStateLabel.Text = "Zapnuta";
            }
            else spiralStateLabel.Text = "Vypnuta";
            if (Simulation.AutomaticControl)
            {
                controlStateLabel.Text = "Automaticke";
            }
            else controlStateLabel.Text = "Manualni";
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
            Simulation.AutomaticControl = !stateControlCheckBox.Checked;
            heatControlCheckBox.Visible = stateControlCheckBox.Checked;
            if (!stateControlCheckBox.Checked)
            {
                controlStateLabel.Text = "Automaticke";
            }
            else controlStateLabel.Text = "Manualni";
            if (heatControlCheckBox.Visible == false)
            {
                heatControlCheckBox.Checked = false;
            }
        }

        private void heatControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Simulation.Boiler.Heating = heatControlCheckBox.Checked;
            if (Simulation.Boiler.Heating)
            {
                spiralStateLabel.Text = "Zapnuta";
            }
            else spiralStateLabel.Text = "Vypnuta";

        }

        private void timeMultiplierTrackBar_Scroll(object sender, EventArgs e)
        {
            Simulation.TimeMultiplier = timeMultiplierTrackBar.Value;
            timeMultiplierLabel.Text = $"{timeMultiplierTrackBar.Value}x";
        }
    }
}
