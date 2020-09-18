using System;

namespace CarRepairManagementSystem
{
    class Controller
    {
        CrudOperationInVehicles crud = new CrudOperationInVehicles();

        public void ListAllVehicle()
        {
            crud.GetAllVehicles();
        }

        public void InsertVehicle()
        {
            int year = 0;
            bool flag = true;

            Console.WriteLine("Enter the make: \n");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the model: \n");
            string model = Console.ReadLine();

            while (flag)
            {
                try
                {
                    Console.WriteLine("\n Enter the Year : ");
                    year = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("\n Please enter a valid value\n ");
                }
            }
            Console.WriteLine("Enter the status : \n");
            string condition = Console.ReadLine();

            crud.InsertVehicle(make, model, year, condition);

            Console.WriteLine("Entry Inserted successfuly !!");
        }
        public void UpdateVehicle()
        {
            int year = 0;
            int id = 0;

            try
            {
                Console.WriteLine("Enter The Vehicle Id to update a record: ");
                id = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nPlease enter a valid value for the ID\n ");
            }
            if (crud.GetVehicleById(id) <0)
                Console.WriteLine("\n ID not found\n");
            else
            {
                Console.WriteLine("\nEnter the Make of the car: ");
                string make = Console.ReadLine();

                Console.WriteLine("\nEnter the Model of the car: ");
                string model = Console.ReadLine();
                bool flag = true;

                while (flag)
                {
                    try
                    {
                        Console.WriteLine("\nEnter the Year of the car: ");
                        year = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid value for the Year\n ");
                    }
                }
                Console.WriteLine("\n Enter the status : ");
                string status = Console.ReadLine();
                crud.UpdateVehicle(id, make, model, year, status);

                crud.GetAllVehicles();
            }
        }
        public void DeleteVehicle()
        {
            try
            {
                int id = 0;
                try
                {
                    Console.WriteLine("Enter the ID to delete: ");
                    id = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nPlease enter a valid value for the ID\n ");
                }
                if (crud.GetVehicleById(id) <0)
                    Console.WriteLine("\n Data not found \n");
                else
                {
                    crud.DeleteVehicle(id);
                    Console.WriteLine("Succefully deleted");
                    crud.GetAllVehicles();
                }
            }
            catch
            {
                Console.WriteLine("\nForeign key error");
            }
        }

        public void ViewVehicleInventory()
        {
            crud.GetAllVehicleInventory();
        }

        public void InsertInventory()
        {
            Console.WriteLine("Enter the vehicleID: ");
            int veichID = 0;
            try
            {
                veichID = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nPlease enter a valid value for the ID\n ");
            }
            if (crud.GetVehicleById(veichID) <0)
            {
                Console.WriteLine("Foreign Key Error! ");
            }
            else
            {
                bool flag = true;
                int qty = 0;
                decimal prc = 0;
                decimal cost = 0;

                while (flag)
                {
                    try
                    {
                        Console.WriteLine("Enter the Number On Hands : ");
                        qty = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid value!\n ");
                    }
                }
                flag = true;
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("Enter the Price : ");
                        prc = decimal.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid value!\n ");
                    }
                }
                flag = true;
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("Enter the cost : ");
                        cost = decimal.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid value!\n ");
                    }
                }
                crud.InsertVehicleInventory(veichID, qty, prc, cost);
                Console.WriteLine("\nSuccessfully Inserted!! ");
            }
        }
        public void UpdateInventory()
        {
            bool flag = true;
            int id = 0;
            int veichID = 0;
            int qty = 0;
            decimal cost = 0;
            decimal prc = 0;

            while (flag)
            {
                try
                {
                    Console.WriteLine("\nEnter the Inventory ID to update: ");
                    id = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("\nPlease enter a valid value!");
                }
            }
            if (crud.GetInventoryById(id) <0)
                Console.WriteLine("\nData not found");
            else
            {
                flag = true;
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("Enter the vehicleID: ");
                        veichID = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid  value!");
                    }
                }
                if (crud.GetVehicleById(veichID) <0)
                    Console.WriteLine("Foreign Key Error! ");
                else
                {
                    flag = true;
                    while (flag)
                    {
                        try
                        {
                            Console.WriteLine("Enter the Number On Hands : ");
                            qty = int.Parse(Console.ReadLine());
                            flag = false;
                        }
                        catch
                        {
                            Console.WriteLine("\nPlease enter a valid value!\n ");
                        }
                    }
                    flag = true;
                    while (flag)
                    {
                        try
                        {
                            Console.WriteLine("Enter the Price : ");
                            prc = decimal.Parse(Console.ReadLine());
                            flag = false;
                        }
                        catch
                        {
                            Console.WriteLine("\nPlease enter a valid value!\n ");
                        }
                    }
                    flag = true;
                    while (flag)
                    {
                        try
                        {
                            Console.WriteLine("Enter the cost : ");
                            cost = decimal.Parse(Console.ReadLine());
                            flag = false;
                        }
                        catch
                        {
                            Console.WriteLine("\nPlease enter a valid value!\n ");
                        }
                    }
                    crud.UpdateVehicleInventory(id, veichID, qty, prc, cost);
                    Console.WriteLine("\n Succesfully Updated!! ");
                }
            }
        }
        public void DeleteInventory()
        {
            try
            {
                int id = 0;
                try
                {
                    Console.WriteLine("Enter the InventoryId to delete: ");
                    id = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter valid ID to Delete !! ");
                }
                if (crud.GetInventoryById(id) <0)
                    Console.WriteLine("\nData not found\n");
                else
                {
                    crud.DeleteVehicleInventory(id);
                    Console.WriteLine("\nSuccesfully Deleted!! ");
                }
            }
            catch
            {
                Console.WriteLine("\nForeign key error");
            }
        }

        public void ViewRepair()
        {
            crud.GetAllRepairs();
        }

        public void InsertRepiar()
        {
            bool flag = true;
            int id = 0;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\nEnter the InventoryID: ");
                    id = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("\n Invalid input! \n ");
                }
            }
            if (crud.GetInventoryById(id) <0)
            {
                Console.WriteLine("Foreign key error");
            }
            else
            {
                Console.WriteLine("Enter what to Repair: ");
                string Repair = Console.ReadLine();
                crud.InsertRepair(id, Repair);
                Console.WriteLine("Successfully Inserted!! ");
            }
        }

        public void UpdateRepair()
        {
            bool flag = true;
            int RepairId = 0;
            int inventoryId = 0;

            while (flag)
            {
                try
                {
                    Console.WriteLine("Enter Repair ID to update: ");
                    RepairId = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("\nPlease enter a valid value! ");
                }
            }
            if (crud.GetRepairById(RepairId) <0)
            {
                Console.WriteLine("The Foreign Key you inserted does not exsist");
            }
            else
            {
                flag = true;
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("\nEnter the Inventory ID: ");
                        inventoryId = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input! ");
                    }
                }
                if (crud.GetInventoryById(inventoryId) <0)
                    Console.WriteLine("The Foreign Key you inserted does not exsist ");
                else
                {
                    Console.WriteLine("Enter what to Repair: ");
                    string Repair = Console.ReadLine();
                    crud.UpdateRepair(RepairId, inventoryId, Repair);
                    Console.WriteLine("Successfully Inserted!! ");
                }
            }
        }

        public void DeleteRepair()
        {
            try
            {
                bool flag = true;
                int id = 0;
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("Enter the Repair Id to delete: ");
                        id = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("\n Invalid input! ");
                    }
                }

                if (crud.GetRepairById(id) <0)
                    Console.WriteLine("\n No id found ");
                else
                {
                    crud.DeleteRepair(id);
                    Console.WriteLine("\n Deleted succesfully !! ");
                }
            }
            catch
            {
                Console.WriteLine("UNABLE TO DELETE");
            }
        }

    }
}
