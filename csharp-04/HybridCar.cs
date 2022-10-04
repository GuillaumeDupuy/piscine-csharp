using System;
namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car, IThermalCar, IElectricCar
    {

        public int FuelLevel { get; set; }
        public int BatteryLevel { get; set; }

        public void FillUp()
        {
            FuelLevel = 100;
        }

        public int GetBatteryLevel()
        {
            return BatteryLevel;
        }

        public int GetFuelLevel()
        {
            return FuelLevel;
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public HybridCar() {
            
        }

        public HybridCar(string Model, string Brand, string Color, int CurrentSpeed = 0) : base(Model, Brand, Color, CurrentSpeed){
            this.FuelLevel = 100;
            this.BatteryLevel = 100;
        }

        public override string ToString()
        {
            return base.ToString() + ", Battery: " + BatteryLevel + "%, Fuel: " + FuelLevel +"%";
        }
    }
}