namespace ParkingSystem.Models;

public class Vehicles
{
    public string NumberPlate { get; set; }
    public string Color { get; set; }
    public ETypeVehicles TypeVehicles { get; set; }

    public override string ToString()
    {
        return $"{nameof(NumberPlate)}: {NumberPlate}, {nameof(Color)}: {Color}, {nameof(TypeVehicles)}: {TypeVehicles}";
    }
}