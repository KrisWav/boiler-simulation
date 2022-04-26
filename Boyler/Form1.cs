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
            timuMultiplierComboBox.SelectedIndex = 0;
        }

        private void showerTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Simulation.WaterAppliance.ShowerFlow = (double)showerTrackBar.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Simulation.Boiler.SetWaterFlow(Simulation.WaterAppliance);
            waterFlowLabel.Text = $"{Math.Round(Simulation.Boiler.WaterFlowPerMinute, 1)}l/min";
            Simulation.CalculateConsumedWater(timer.Interval * TimeMultiplier);
            waterConsumptionLabel.Text = $"{Math.Round(Simulation.ConsumedWater, 1)}l";
            Simulation.AddTime(timer.Interval * TimeMultiplier);
            simulationTimeLabel.Text = Simulation.Time.ToString();

            Simulation.CalculateEnergyConsumption(timer.Interval * TimeMultiplier);
            energyConsumptionLabel.Text = $"{Math.Round(Simulation.EnergyConsumption, 1)}Wh";


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

            if (Simulation.AutomaticControl)
            {
                Simulation.AutomaticRun();
            }
            else
            {
                Simulation.CalculateHeating(timer.Interval * TimeMultiplier);
                boilerTempLabel.Text = $"{Math.Round(Simulation.Boiler.CurrentTemperature, 2)} Celsius";
            }
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
                Simulation.AutomaticControl = !stateControlCheckBox.Checked;
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

        private void fastTimeButton_Click(object sender, EventArgs e)
        {
            TimeMultiplier = 10;
            Simulation.TimeMultiplier = 10;
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

        private void timuMultiplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Simulation.TimeMultiplier = int.Parse(timuMultiplierComboBox.SelectedItem.ToString());
            TimeMultiplier = int.Parse(timuMultiplierComboBox.SelectedItem.ToString());
        }
    }
}
