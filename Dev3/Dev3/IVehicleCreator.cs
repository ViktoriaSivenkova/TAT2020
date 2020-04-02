using Dev3.Vehicles;
using System;


namespace Dev3
{
    public interface IVehicleCreator
    {
        Car GetNewHeatEngineCarWithManualTransmission();
        Car GetNewHeatEngineCarWithAutomaticTransmission();
        Bus GetNewBusWith45Places();
        Truck GetNewTruckWithManualTransmission();
    }
}
