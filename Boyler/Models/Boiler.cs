using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boyler.Models
{
    public class Boiler
    {
        public double CurrentTemperature { get; set; }
        public double LastTemperature { get; set; }
        public double WaterFlowPerMinute { get; set; }
        public double WaterFlowPerSecond { get; set; }
        public bool Heating { get; set; }
        public double ConsumedWater { get; set; }
        public double HeatingPower { get; }
        public double VolumeLiters { get; }
        public Boiler()
        {
            CurrentTemperature = 50;
            HeatingPower = 4000;
            VolumeLiters = 125 * Math.PI;
            WaterFlowPerSecond = 0;
            WaterFlowPerMinute = 0;
        }
        public void SetWaterFlow(WaterAppliance appliance)
        {
            if (appliance.Shower == 0 || appliance.ShowerFlow == 0)
            {
                WaterFlowPerMinute = (appliance.SinkFlow * (appliance.Sink / 100));
            }
            else if (appliance.Sink == 0 || appliance.SinkFlow == 0)
            {
                WaterFlowPerMinute = (appliance.ShowerFlow * (appliance.Shower / 100));
            }
            else
                WaterFlowPerMinute = (appliance.ShowerFlow * (appliance.Shower / 100)) + (appliance.SinkFlow * (appliance.Sink / 100));
            WaterFlowPerSecond = WaterFlowPerMinute / 60;
        }
    }
}
