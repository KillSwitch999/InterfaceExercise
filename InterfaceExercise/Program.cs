using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                NumberOfWheels = 4,
                Color = "Red",
                HasHeadlights = true,
                TransmissionType = "Automatic",
                HasTrunk = true,
                BodyStyle = "Sedan",
                Logo = "Toyota",
                HeadquartersLocation = "Japan"
            };

            var truck = new Truck
            {
                NumberOfWheels = 4,
                Color = "Black",
                HasHeadlights = true,
                TransmissionType = "Manual",
                BedSize = 6.5,
                IsFourWheelDrive = true,
                Logo = "Ford",
                HeadquartersLocation = "USA"
            };

            var suv = new SUV
            {
                NumberOfWheels = 4,
                Color = "White",
                HasHeadlights = true,
                TransmissionType = "Automatic",
                NumberOfSeats = 7,
                HasRoofRack = true,
                Logo = "Honda",
                HeadquartersLocation = "Japan"
            };

            car.DisplayDetails();
            truck.DisplayDetails();
            suv.DisplayDetails();

        }

        
    }
}
