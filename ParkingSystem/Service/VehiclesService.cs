using ParkingSystem.Models;

namespace ParkingSystem.Service;

public class VehiclesService
{
    public static List<Vehicles> ListParkingLot = new List<Vehicles>();
    private static int numberOfPark;
    
    public static void CreateParkingLot()
    {
        Console.Write("How many parking lot you want to make: ");
        numberOfPark = Convert.ToInt16(Console.ReadLine());
        
        for (int i = 0; i < numberOfPark; i++)
        {
            ListParkingLot.Add(null);
        }

        Console.WriteLine();
        Console.WriteLine($"Created a parking lot with {numberOfPark} slots");
        Hold();
    }

    public static void Parking()
    {
        int numberParkingLotNotNull = 0;
        foreach (var vehicle in ListParkingLot)
        {
            if (vehicle != null)
            {
                numberParkingLotNotNull++;
            }
        }
        
        if (numberOfPark > numberParkingLotNotNull)
        {
            Console.Write("Vehicle Type (Car/Motorcycle): ");
            string vehicleType = Console.ReadLine();

            if (vehicleType.ToLower() == "car" || vehicleType.ToLower() == "motorcycle")
            {
                Console.Write("Vehicle Color: ");
                string vehicleColor = Console.ReadLine();

                Console.Write("Number Of Plate (x-1234-xx): ");
                string numberOfPlate = Console.ReadLine();

                Vehicles vehicles = new Vehicles
                {
                    NumberPlate = numberOfPlate,
                    Color = vehicleColor,
                    TypeVehicles = Enum.Parse<ETypeVehicles>(vehicleType, true)

                };

                for (int i = 0; i < ListParkingLot.Count; i++)
                {
                    if (ListParkingLot[i] == null)
                    {
                        ListParkingLot[i] = vehicles;
                        Console.WriteLine();
                        Console.WriteLine($"Allocated slot number: {i+1}");
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Vehicle must be Car or Motorcycle!");
                ProgramService.Main();
                
            }
            
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, parking lot is full");
        }
        Hold();
    }
    public static void Leaving()
    {
        Console.Write("Input slot number: ");
        int slotNumber = Convert.ToInt16(Console.ReadLine());

        ListParkingLot[slotNumber - 1] = null;

        Console.WriteLine();
        Console.WriteLine($"Slot number {slotNumber} is free");
        Hold();
    }
    public static void Hold()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}