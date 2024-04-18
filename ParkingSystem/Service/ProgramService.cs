namespace ParkingSystem.Service;

public class ProgramService
{
    public static void Main()
    {
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine();
            Console.WriteLine("""
                              ----------------------
                                Parking System App
                              ----------------------
                              Menu:
                              1. Create Parking
                              2. Parking
                              3. Leaving
                              4. Report
                              5. Exit

                              """);
            Console.Write("Please choose from menu above: ");
            int selectedMenu = Convert.ToUInt16(Console.ReadLine());
            
            switch (selectedMenu)
            {
                case 1:
                    VehiclesService.CreateParkingLot();
                    break;
                case 2:
                    VehiclesService.Parking();
                    break;
                case 3:
                    VehiclesService.Leaving();
                    break;
                case 4:
                    bool repeatForReport = true;
                    while (repeatForReport)
                    {
                        Console.WriteLine();
                        Console.WriteLine("""
                                          ----------
                                            Report
                                          ----------
                                          Menu:
                                          0. Back
                                          1. Parking lot occupied
                                          2. Parking lot free
                                          3. Vehicle with odd plat number
                                          4. Vehicle with even plat number
                                          5. Number of car
                                          6. Number of motorcycle
                                          7. Vehicle plate from color
                                          8. Slot number from color
                                          9. Slot number from number plate
                                          10. Status
                                          
                                          """);
                        Console.Write("Please choose from menu above: ");
                        int selectedMenuForReport = Convert.ToUInt16(Console.ReadLine());
                        switch (selectedMenuForReport)
                        {
                            case 1:
                                ParkingService.ParkingOccupied();
                                break;
                            case 2:
                                ParkingService.ParkingFree();
                                break;
                            case 3:
                                ParkingService.VehicleOdd();
                                break;
                            case 4:
                                ParkingService.VehicleEven();
                                break;
                            case 5:
                                ParkingService.NumberOfCar();
                                break;
                            case 6:
                                ParkingService.NumberOfMotorCycle();
                                break;
                            case 7:
                                ParkingService.VehiclePlateFromColor();
                                break;
                            case 8:
                                ParkingService.SlotNumberFromColor();
                                break;
                            case 9:
                                ParkingService.SlotNumberFromPlateNumber();
                                break;
                            case 10:
                                ParkingService.Status();
                                break;
                            case 0:
                                repeatForReport = false;
                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("Command not found");
                                break;
                        }
                        
                    }
                    
                    break;
                case 5:
                    Console.WriteLine("Thank You!");
                    repeat = false;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Command not found");
                    break;
            }
        }
    }
}