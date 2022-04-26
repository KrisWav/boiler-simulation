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
        public Simulation()
        {
            WaterHeatCapacity = 4180/3600;
            TuvWaterTemperature = 10;
            Boiler = new Boiler();
            WaterAppliance = new WaterAppliance();
            Time = new TimeSpan();
        }
        //public double CalculateBoilerHeatChange(Boiler boiler)
        //{

        //}
        public void AddTime(int ms)
        {
            Time = Time.Add(new TimeSpan(0,0,0,0,ms));
        }
        public void CalculateHeating(int time)
        {
            var timeSpan = new TimeSpan(0, 0, 0, 0, time);
            if (Boiler.Heating)
            {
                Boiler.CurrentTemperature = ((Boiler.HeatingPower*timeSpan.TotalHours)/(Boiler.VolumeLiters*WaterHeatCapacity))+ Boiler.CurrentTemperature;
            }
        }
    }
}
