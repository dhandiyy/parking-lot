using ParkingSystem.Models;

namespace ParkingSystem.Service;

public class ParkingService
{
    public static void ParkingOccupied()
    {
        int numberParkingLotNotNull = 0;
        foreach (var vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle != null)
            {
                numberParkingLotNotNull++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Parking lots occupied are {numberParkingLotNotNull}");
        Hold();
    }
    
    public static void ParkingFree()
    {
        int numberParkingLotNull = 0;
        foreach (var vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle == null)
            {
                numberParkingLotNull++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Parking lots free are {numberParkingLotNull}");
        Hold();
    }
    public static void VehicleOdd()
    {
        int check = 0;
        foreach (Vehicles vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle != null)
            {
                string vehiclePlate = vehicle.NumberPlate;
                int firstDashIndex = vehiclePlate.IndexOf("-") + 1;
                int secondDashIndex = vehiclePlate.IndexOf("-", firstDashIndex + 1);
                int length = secondDashIndex - firstDashIndex; 

                long extractedNumber = Convert.ToInt64(vehiclePlate.Substring(firstDashIndex, length));

                if (extractedNumber % 2 != 0)
                {
                    Console.WriteLine(vehiclePlate);
                    check++;
                }
            }
          
        }
        if (check == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Not Found");
        }
        Hold();
    }
    
    public static void VehicleEven()
    {
        int check = 0;
        foreach (Vehicles vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle != null)
            {
                string vehiclePlate = vehicle.NumberPlate;
                int firstDashIndex = vehiclePlate.IndexOf("-") + 1;
                int secondDashIndex = vehiclePlate.IndexOf("-", firstDashIndex + 1);
                int length = secondDashIndex - firstDashIndex; 

                long extractedNumber = Convert.ToInt64(vehiclePlate.Substring(firstDashIndex, length));

                if (extractedNumber % 2 == 0)
                {
                    Console.WriteLine(vehiclePlate);
                    check++;
                }
            }
        }
        if (check == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Not Found");
        }
        Hold();
    }
    
    public static void NumberOfCar()
    {
        int numberOfCars = 0;
        foreach (Vehicles vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle != null)
            {
                if (vehicle.TypeVehicles == ETypeVehicles.Car)
                {
                    numberOfCars++;
                }
            }
        }

        Console.WriteLine(numberOfCars);
        Hold();

    }
    
    public static void NumberOfMotorCycle()
    {
        int numberOfMotorCycles = 0;
        foreach (Vehicles vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle != null)
            {
                if (vehicle.TypeVehicles == ETypeVehicles.Motorcycle)
                {
                    numberOfMotorCycles++;
                }
            }
        }

        Console.WriteLine(numberOfMotorCycles);
        Hold();
    }
    
    public static void VehiclePlateFromColor()
    {
        Console.Write("Color of vehicle: ");
        string color = Console.ReadLine().ToLower();
        int check = 0;
        foreach (Vehicles vehicle in VehiclesService.ListParkingLot)
        {
            if (vehicle != null && vehicle.Color.ToLower() == color)
            {
                Console.WriteLine(vehicle.NumberPlate);
                check++;

            }
          
        }
        if (check == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Not Found");
        }
        Hold();
    }
    
    public static void SlotNumberFromColor()
    {
        Console.Write("Color of vehicle: ");
        string color = Console.ReadLine().ToLower();
        int check = 0;
        for (int i = 0; i < VehiclesService.ListParkingLot.Count; i++)
        {
            Vehicles vehicles = VehiclesService.ListParkingLot[i];
            if (vehicles != null && vehicles.Color.ToLower() == color)
            {
                Console.WriteLine(i+1);
                check++;

            }
            
        }
        if (check == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Not Found");
        }
        Hold();
    }
    
    public static void SlotNumberFromPlateNumber()
    {
        Console.Write("Plate number of vehicle: ");
        string numberPlate = Console.ReadLine().ToLower();
        int check = 0;
        for (int i = 0; i < VehiclesService.ListParkingLot.Count; i++)
        {
            Vehicles vehicles = VehiclesService.ListParkingLot[i];
            if (vehicles != null && vehicles.NumberPlate.ToLower() == numberPlate)
            {
                Console.WriteLine(i+1);
                check++;

            }
            
        }

        if (check == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Not Found");
        }
        Hold();
    }
    
    public static void Status()
    {
        Console.WriteLine("Slot\tNo.\tType\t\tColour");
        Console.WriteLine("----\t----\t----\t\t-------");
        for (int i = 0; i < VehiclesService.ListParkingLot.Count(); i++)
        {
            Vehicles vehicle = VehiclesService.ListParkingLot[i];

            if (vehicle != null)
            {
                Console.WriteLine($"{i + 1}\t{vehicle.NumberPlate}\t{vehicle.TypeVehicles}\t{vehicle.Color}");
            }
            
        }
        Hold();
    }

    public static void Hold()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}