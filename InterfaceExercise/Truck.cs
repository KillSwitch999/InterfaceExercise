using System;
namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public double BedSize { get; set; }
    public bool IsFourWheelDrive { get; set; }

    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool HasHeadlights { get; set; }
    public string TransmissionType { get; set; }

    public string Logo { get; set; }
    public string HeadquartersLocation { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Truck - {Color}, Bed Size: {BedSize}ft, 4WD: {IsFourWheelDrive}, {NumberOfWheels} wheels, {TransmissionType} transmission.");
        Console.WriteLine($"Logo: {Logo}, HQ: {HeadquartersLocation}");
        Console.WriteLine("----------------------------------------");
    }
}
