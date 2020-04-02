using Dev3.VehicleComponents;
using Dev3.Vehicles;
using System;
using System.Collections.Generic;

namespace Dev3
{
    public class EntryPoint
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                List<BaseVehicle> autoPark = new List<BaseVehicle>();

                IVehicleCreator vehicleCreator = new VehicleCreator();
                var carAutomat = vehicleCreator.GetNewHeatEngineCarWithAutomaticTransmission();
                var carManual = vehicleCreator.GetNewHeatEngineCarWithManualTransmission();
                var bus45Places = vehicleCreator.GetNewBusWith45Places();
                var truckManual = vehicleCreator.GetNewTruckWithManualTransmission();

                autoPark.Add(carAutomat);
                autoPark.Add(carAutomat);
                autoPark.Add(carManual);
                autoPark.Add(carManual);
                autoPark.Add(carManual);
                autoPark.Add(bus45Places);
                autoPark.Add(bus45Places);
                autoPark.Add(truckManual);
                autoPark.Add(truckManual);







            }

            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message); // Output any exception message to console.
            }
        }
    }
}