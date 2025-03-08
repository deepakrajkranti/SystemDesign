

namespace LLD.ParkingLot
{
    public class Level
    {
        private readonly int floor;
        private readonly List<ParkingSpot> parkingSpots;
        public Level(int floor,int numSpots) {
            this.floor = floor;
            parkingSpots = new List<ParkingSpot>(numSpots);


            double spotsForBikes = 0.50;
            double spotsForCars = 0.40;

            int numBikes = (int)(numSpots * spotsForBikes);
            int numCars = (int)(numSpots * spotsForCars);

            for (int i = 1; i <= numBikes; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, VehicleType.MOTORCYCLE));
            }
            for (int i = numBikes + 1; i <= numBikes + numCars; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, VehicleType.CAR));
            }
            for (int i = numBikes + numCars + 1; i <= numSpots; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, VehicleType.TRUCK));
            }

        }

        public bool hasSpot(Vehicle vehicle)
        {
            foreach (ParkingSpot spot in parkingSpots)
            {
                if (spot.IsAvailable && spot.VehicleType == vehicle.GetVehicleType())
                {
                    return true;
                }
            }
            return false;
        }

        public bool parkVehicle(Vehicle vehicle)
        {
            foreach (ParkingSpot spot in parkingSpots)
            {
                if (spot.IsAvailable && spot.VehicleType == vehicle.GetVehicleType())
                {
                    spot.ParkVehicle();
                    return true;
                }
            }
            return false;
        }


        public bool removeVehicle(Vehicle vehicle)
        {
            foreach (ParkingSpot spot in parkingSpots)
            {
                if (!spot.IsAvailable && spot.VehicleType == vehicle.GetVehicleType())
                {
                    spot.RemoveVehicle();
                    return true;
                }
            }
            return false;
        }

        public void DisplayAvailability()
        {
            Console.WriteLine("Floor: " + floor);
            foreach (ParkingSpot spot in parkingSpots)
            {
                Console.WriteLine("Spot Number: " + spot.SpotNumber + " Vehicle Type: " + spot.VehicleType + " Available: " + spot.IsAvailable);
            }
        }

    }
}
