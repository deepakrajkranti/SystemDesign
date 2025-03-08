namespace LLD.ParkingLot
{
    public class ParkingSpot
    {
        public ParkingSpot(int spotNumber, VehicleType vehicleType)
        {
            SpotNumber = spotNumber;
            VehicleType = vehicleType;
        }

        public int SpotNumber { get; }
        public VehicleType VehicleType { get; }

        public bool IsAvailable { get; set; } = true;

        public void ParkVehicle()
        {
            IsAvailable = false;
        }

        public void RemoveVehicle()
        {
            IsAvailable = true;
        }

    }
}
