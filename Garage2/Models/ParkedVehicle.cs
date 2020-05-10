using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public string RegistrationNumber { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime TimeOfParking { get; set; }
    }

    public enum VehicleType
    {
        Car,
        Boat,
        MotorCycle,
        Buss,
        Airplane,
        Cycle
    }
}
