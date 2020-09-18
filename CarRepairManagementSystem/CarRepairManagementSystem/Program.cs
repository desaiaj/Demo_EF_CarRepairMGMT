using System;

namespace CarRepairManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Console.WriteLine("Welcome!");
            do
            {
                Console.WriteLine("Welcome, Please choose a command: ");
                Console.WriteLine(" Press 1 to modify vehicles");
                Console.WriteLine(" Press 2 to modify inventory");
                Console.WriteLine(" Press 3 to modify repair");
                Console.WriteLine(" Press 4 to exit program");
                string ch = Console.ReadLine();

                if (ch == "1")
                {
                    Console.WriteLine(" Press 1 to list all vehicles");
                    Console.WriteLine(" Press 2 to add a new vehicle");
                    Console.WriteLine(" Press 3 to update a vehicle");
                    Console.WriteLine(" Press 4 to delete a vehicle");
                    Console.WriteLine(" Press 5 to return to main menu ");
                    string VChoice = Console.ReadLine();

                    if (VChoice == "1")
                        controller.ListAllVehicle();
                    else if (VChoice == "2")
                        controller.InsertVehicle();
                    else if (VChoice == "3")
                        controller.UpdateVehicle();
                    else if (VChoice == "4")
                        controller.DeleteVehicle();
                    else if (VChoice == "5")
                        Console.WriteLine("\n Back to the Main Menu\n");
                    else
                        Console.WriteLine("Please Enter the valid choice!");
                }
                else if (ch == "2")
                {
                    Console.WriteLine(" Press 1 to Insert new Inventory");
                    Console.WriteLine(" Press 2 to view inventory for a vehicle");
                    Console.WriteLine(" Press 3 to update vehicle inventory");
                    Console.WriteLine(" Press 4 to delete vehicle invontery");
                    Console.WriteLine(" Press 5 to return to main menu ");
                    string inventoryChoice = Console.ReadLine();

                    if (inventoryChoice == "1")
                        controller.InsertInventory();
                    else if (inventoryChoice == "2")
                        controller.ViewVehicleInventory();
                    else if (inventoryChoice == "3")
                        controller.UpdateInventory();
                    else if (inventoryChoice == "4")
                        controller.DeleteInventory();
                    else if (inventoryChoice == "5")
                        Console.WriteLine("\n Back to the Main Menu\n");
                    else
                        Console.WriteLine("Please Enter the valid choice!");
                }
                else if (ch == "3")
                {
                    Console.WriteLine(" Press 1 to view all Repairs");
                    Console.WriteLine(" Press 2 to add a new Repair ");
                    Console.WriteLine(" Press 3 to update a Repair");
                    Console.WriteLine(" Press 4 to delete a Repair");
                    Console.WriteLine(" Press 5 to return to main menu ");
                    string repairChoice = Console.ReadLine();
                    if (repairChoice == "1")
                        controller.ViewRepair();
                    else if (repairChoice == "2")
                        controller.InsertRepiar();
                    else if (repairChoice == "3")
                        controller.UpdateRepair();
                    else if (repairChoice == "4")
                        controller.DeleteRepair();
                    else if (repairChoice == "5")
                        Console.WriteLine("\n Back to the Main Menu\n");
                    else
                        Console.WriteLine("Please Enter the valid choice!");
                }
                else if (ch == "4")
                    Environment.Exit(0);
                else
                    Console.WriteLine("invalid choice! Try again");
            } while (true);
        }
    }
}
