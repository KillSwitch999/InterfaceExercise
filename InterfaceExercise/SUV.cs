using System;
namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; }
    public bool HasRoofRack { get; set; }

    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool HasHeadlights { get; set; }
    public string TransmissionType { get; set; }

    public string Logo { get; set; }
    public string HeadquartersLocation { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"SUV - {Color}, Seats: {NumberOfSeats}, Roof Rack: {HasRoofRack}, {NumberOfWheels} wheels, {TransmissionType} transmission.");
        Console.WriteLine($"Logo: {Logo}, HQ: {HeadquartersLocation}");
        Console.WriteLine("----------------------------------------");
    }
}
