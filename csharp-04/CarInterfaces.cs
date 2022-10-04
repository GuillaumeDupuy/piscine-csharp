using System;
namespace CSharpDiscovery.Quest04
{
    public interface IThermalCar 
    {
        int FuelLevel {get; set;}

        void FillUp();

        int GetFuelLevel();
    }

    public interface IElectricCar
    {
        int BatteryLevel {get; set;}

        void Recharge();

        int GetBatteryLevel();
    }

}
