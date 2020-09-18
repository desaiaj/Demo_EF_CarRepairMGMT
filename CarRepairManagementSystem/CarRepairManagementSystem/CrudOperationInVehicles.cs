using System;

namespace CarRepairManagementSystem
{
    class CrudOperationInVehicles
    {
        private CarRepairDataSetTableAdapters.vehicleTableAdapter _adpVehicles;
        private CarRepairDataSet.vehicleDataTable _tblVehicles;

        private CarRepairDataSetTableAdapters.vehicleInventoryTableAdapter _adpInventory;
        private CarRepairDataSet.vehicleInventoryDataTable _tblInventory;

        private CarRepairDataSetTableAdapters.RepairTableAdapter _adpRepairs;
        private CarRepairDataSet.RepairDataTable _tblRepairs;

        internal CrudOperationInVehicles()
        {
            _adpVehicles = new CarRepairDataSetTableAdapters.vehicleTableAdapter();
            _tblVehicles = new CarRepairDataSet.vehicleDataTable();

            _adpInventory = new CarRepairDataSetTableAdapters.vehicleInventoryTableAdapter();
            _tblInventory = new CarRepairDataSet.vehicleInventoryDataTable();

            _adpRepairs = new CarRepairDataSetTableAdapters.RepairTableAdapter();
            _tblRepairs = new CarRepairDataSet.RepairDataTable();
        }

        public void GetAllVehicles()
        {
            _tblVehicles = _adpVehicles.GetVehicles();

            foreach (var row in _tblVehicles)
            {
                Console.WriteLine($"{row.vehicleID,5} {row.Make,-15} {row.Model,-15} {row.Year,-15} {row.NewOrUsed,-15}");
            }
        }

        public int GetVehicleById(int id)
        {
            int flag = 0;
            _tblVehicles = _adpVehicles.GetVehicles();
            var row = _tblVehicles.FindByvehicleID(id);

            if (row != null)
            {
                Console.WriteLine($"{row.vehicleID,5} {row.Make,5} {row.Model} {row.Year} {row.NewOrUsed}");
            }
            else
            {
                Console.WriteLine("Invalid Vehicle ID. Please try again.! ");
                flag = -1;
            }
            return flag;
        }
        public void InsertVehicle(string make, string model, int year, string status)
        {
            _adpVehicles.Insert(make, model, year, status);
        }
        public void UpdateVehicle(int id, string make, string model, int year, string status)
        {
            _adpVehicles.Update(make, model, year, status, id);
        }

        public void DeleteVehicle(int id)
        {
            _adpVehicles.Delete(id);
        }

        public void GetAllVehicleInventory()
        {
            _tblInventory = _adpInventory.GetVehicleInventory();
            Console.WriteLine("InventoryID \tVehicleID \tNumber_On_Hand\t\tPrice\t\tCost");
            foreach (var row in _tblInventory)
            {
                Console.WriteLine($"{row.InventoryID,10} {row.vehicleID,15} {row.NumberOnHand,20} {row.Price,15} {row.Cost,15}");
            }
        }

        public int GetInventoryById(int id)
        {
            int flag = 0;
            _tblInventory = _adpInventory.GetVehicleInventory();
            var row = _tblInventory.FindByInventoryID(id);

            if (row != null)
                Console.WriteLine($"{row.InventoryID} {row.vehicleID,15} {row.NumberOnHand,16} {row.Price,15} {row.Cost,15}");
            else
            {
                Console.WriteLine("Invalid Vehicle ID. Please try again! ");
                flag = -1;
            }
            return flag;
        }
        public void InsertVehicleInventory(int id, int qty, decimal prc, decimal cost)
        {
            _adpInventory.Insert(id, qty, prc, cost);
        }
        public void UpdateVehicleInventory(int id, int vehicleId, int qty, decimal price, decimal cost)
        {
            _adpInventory.Update(vehicleId, qty, price, cost, id);
        }

        public void DeleteVehicleInventory(int id)
        {
            _adpInventory.Delete(id);
        }

        public void GetAllRepairs()
        {
            _tblRepairs = _adpRepairs.GetRepairs();
            Console.WriteLine("RepairID InventoryID \t Repairing_Work");
            foreach (var row in _tblRepairs)
            {
                Console.WriteLine($"{row.RepairID,8} {row.InventoryID,11}   {row.WhatToRepair,12}");
            }
        }
        public int GetRepairById(int id)
        {
            int flag = 0;
            _tblRepairs = _adpRepairs.GetRepairs();
            var row = _tblRepairs.FindByRepairID(id);

            if (row != null)
            {
                Console.WriteLine($"{row.RepairID} {row.InventoryID,14} {row.WhatToRepair,12}");
            }
            else
            {
                Console.WriteLine("Invalid Vehicle ID. Please try again! ");
                flag = -1;
            }
            return flag;
        }

        public void InsertRepair(int id, string work)
        {
            _adpRepairs.Insert(id, work);
        }

        public void UpdateRepair(int repairID, int inventoryId, string work)
        {
            _adpRepairs.Update(inventoryId, work, repairID);
        }

        public void DeleteRepair(int id)
        {
            _adpRepairs.Delete(id);
        }
    }
}
