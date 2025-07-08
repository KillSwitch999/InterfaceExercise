using System;
namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public string BodyStyle { get; set; }

    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool HasHeadlights { get; set; }
    public string TransmissionType { get; set; }

    public string Logo { get; set; }
    public string HeadquartersLocation { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car - {Color}, {BodyStyle}, Has Trunk: {HasTrunk}, {NumberOfWheels} wheels, {TransmissionType} transmission.");
        Console.WriteLine($"Logo: {Logo}, HQ: {HeadquartersLocation}");
        Console.WriteLine("----------------------------------------");
    }
}
