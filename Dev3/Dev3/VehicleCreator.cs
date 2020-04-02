using Dev3.VehicleComponents;
using Dev3.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev3
{
    public class VehicleCreator : IVehicleCreator
    {
        public Car GetNewHeatEngineCarWithManualTransmission()
        {
            var engine = new Engine(165, 3000, "Heat", "T34FFDS543FDSH");
            var chassis = new Chassis(4, "FJDSJ3242", 1000);
            var transmission = new Transmission("Manual", 8, "ZF");
            return new Car("BMB", "red", engine, transmission, chassis);
        }

        public Car GetNewHeatEngineCarWithAutomaticTransmission()
        {
            var engine = new Engine(120, 1500, "Heat", "T34GDJKH3FDSH");
            var chassis = new Chassis(4, "FJDSJ3242", 1000);
            var transmission = new Transmission("Automatic", 8, "ZF");
            return new Car("Reno", "black", engine, transmission, chassis);
        }
        public Bus GetNewBusWith45Places()
        {
            var engine = new Engine(150, 1500, "Heat", "RTGGDS543FDSH");
            var chassis = new Chassis(4, "FJDSJ3242", 1000);
            var transmission = new Transmission("Automatic", 8, "ZF");
            return new Bus( 45, engine, transmission, chassis);
        }

        public Truck GetNewTruckWithManualTransmission()
        {
            var engine = new Engine(165, 3000, "Heat", "T34FFDS543FDSH");
            var chassis = new Chassis(4, "FJDSJ3242", 1000);
            var transmission = new Transmission("Manual", 8, "ZF");
            return new Truck("Jumbo", 5000, engine, transmission, chassis);
        }
    }
}
