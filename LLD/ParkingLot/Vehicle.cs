namespace LLD.ParkingLot
{
    public abstract class Vehicle
    {
        protected string vehiclePlate;

        protected VehicleType vehicleType;
        public Vehicle(string vehiclePlate, VehicleType vehicleType)
        {
            this.vehiclePlate = vehiclePlate;
            this.vehicleType = vehicleType;
        }
        public VehicleType GetVehicleType()
        {
            return vehicleType;
        }
    }
}
