using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boyler.Models
{
    public class Simulation
    {
        public Boiler Boiler { get; set; }
        public bool AutomaticControl { get; set; }
        public WaterAppliance WaterAppliance { get; set; }
        public double TuvWaterTemperature { get; }
        public TimeSpan Time { get; set; }
        public double WaterHeatCapacity { get; }
        public double EnergyConsumption { get; set; }
        public double TimeMultiplier { get; set; }
        public double ConsumedWater { get; set; }
        public double WaterHeatLossPower { get; set; }
        public Simulation()
        {
            WaterHeatCapacity = 4180/3600;
            TuvWaterTemperature = 10;
            Boiler = new Boiler();
            WaterAppliance = new WaterAppliance();
            Time = new TimeSpan();
            TimeMultiplier = 1;
            WaterHeatLossPower = 100;
            ConsumedWater = 0;
        }
        public void AddTime(int ms)
        {
            Time = Time.Add(new TimeSpan(0,0,0,0,ms));
        }
        public void CalculateConsumedWater(int ms)
        {
            ConsumedWater+=Boiler.WaterFlowPerSecond / 1000 * ms;
        }
        public void CalculateHeating(int time)
        {
            var timeSpan = new TimeSpan(0, 0, 0, 0, time);
            if (Boiler.Heating)
            {
                Boiler.LastTemperature = Boiler.CurrentTemperature;
                Boiler.CurrentTemperature = ((Boiler.HeatingPower*timeSpan.TotalHours)/(Boiler.VolumeLiters*WaterHeatCapacity)) + Boiler.LastTemperature;
                Boiler.CurrentTemperature = CalculateCalometricTemp() + CalculateHeatLoss(time);
            }
            else
            {
                Boiler.LastTemperature = Boiler.CurrentTemperature;
                Boiler.CurrentTemperature = CalculateHeatLoss(time) + Boiler.CurrentTemperature;
            }
        }
        public double CalculateCalometricTemp()
        {
            var waterFlow = Boiler.WaterFlowPerSecond / 10 * TimeMultiplier;
            double temp = (waterFlow*TuvWaterTemperature+(Boiler.VolumeLiters-waterFlow)*Boiler.CurrentTemperature) / (Boiler.VolumeLiters);
            return temp;
        }
        public double CalculateHeatLoss(int time)
        {
            double temperatureAfterHeatLoss = 0;
            var timeSpan = new TimeSpan(0, 0, 0, 0, time);
            if(Boiler.CurrentTemperature > 20)
            {
                temperatureAfterHeatLoss = -((WaterHeatLossPower * timeSpan.TotalHours) / (Boiler.VolumeLiters * WaterHeatCapacity));
                return temperatureAfterHeatLoss;
            }
            return 0;
        }
        public void CalculateEnergyConsumption(int time)
        {
            if (Boiler.Heating)
            {
                var timeSpan = new TimeSpan(0, 0, 0, 0, time);
                EnergyConsumption += Boiler.HeatingPower * timeSpan.TotalHours;
            }
        }
        public void AutomaticRun()
        {

        }
    }
}
