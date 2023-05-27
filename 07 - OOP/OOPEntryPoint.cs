namespace CSharpCourse._07___OOP.Inheritance
{
    internal class OOPEntryPoint
    {
        public OOPEntryPoint()
        {
            // Car object has access to properties of the class Vehicle
            Car car = new("BMW")
            {
                CreationYear = 2023
            };
            car.TurnOnRadio();
            car.Reverse();

            // Truck object has access to properties of the class Vehicle
            Truck truck = new("Iveco")
            {
                CreationYear = 2022
            };
            truck.Reverse();

            // Bicycle object has access to properties of the class Vehicle
            Bicycle bicycle = new("Scott")
            {
                CreationYear = 2020,
            };
            bicycle.Reverse();

            void ReadBrand(Vehicle vehicle)
            {
                var message = $"Reading brand {vehicle.Brand} of the vehicle type {vehicle}";
                Console.WriteLine(message);
            }

            /*
             * Polymorphism
             * ReadBrand accepts car, truck and bicycle objects because they ARE vehicles.
            */
            ReadBrand(car);
            ReadBrand(truck);
            ReadBrand(bicycle);
        }
    }
}
