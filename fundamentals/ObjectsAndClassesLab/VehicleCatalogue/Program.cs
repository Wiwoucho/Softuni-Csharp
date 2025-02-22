namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicleCatalogue = new Vehicle();

            string[] vehicle = Console.ReadLine().Split("/");

            while (vehicle[0] != "end")
            {
                string brand = vehicle[1];
                string model = vehicle[2];
                string weightOrHP = vehicle[3];


                if (vehicle[0] == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = weightOrHP
                    };

                    vehicleCatalogue.Car.Add(car);
                }
                else
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weightOrHP
                    };

                    vehicleCatalogue.Truck.Add(truck);
                }

                vehicle = Console.ReadLine().Split("/");
            }



            if (vehicleCatalogue.Car.Count > 0 && vehicleCatalogue.Car != null)
            {
                Console.WriteLine("Cars:");


                foreach (var car in vehicleCatalogue.Car.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }



            if (vehicleCatalogue.Truck.Count > 0 && vehicleCatalogue.Truck != null)
            {

                Console.WriteLine("Trucks:");


                foreach (var truck in vehicleCatalogue.Truck.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
           }
        }
    }

    class Vehicle
    {
        public List<Car> Car { get; set; } = new List<Car>();
        public List<Truck> Truck { get; set; } = new List<Truck>();


    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
}
