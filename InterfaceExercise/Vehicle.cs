namespace InterfaceExercise;

public interface IVehicle
{
    int NumberOfWheels { get; set; }
    string Color { get; set; }
    bool HasHeadlights { get; set; }
    string TransmissionType { get; set; }

    void DisplayDetails(); // Stubbed method
}