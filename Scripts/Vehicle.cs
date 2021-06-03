using System;

namespace DieGarage
{
    public enum VehicleType { Auto, Motorrad }
    public class Vehicle
    {
        public VehicleType vehicleType;
        public string numberPlate;
        public double parkingEndTime;
        public Vehicle(int _id)
        {
            var rnd = new Random(_id);
            vehicleType = (VehicleType)rnd.Next(0, 2);
            numberPlate = HelperFunctions.CreateNumberPlate(_id);
        }
    }
}
