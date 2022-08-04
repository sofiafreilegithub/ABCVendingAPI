using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RushCodeExercise.Models;

namespace RushCodeExercise.Services
{
    public class WarehouseInventoryService : IWarehouseInventoryService
    {
        public List<Inventory> GetWarehouseInventory()
        {
            // It is assumed here that products are already totalized by warehouse. This could be done extracting data from stored procedure.
            var response = new List<Inventory>();
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Beverage", ProductName = "sparkling water", ProductCount = 50 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Beverage", ProductName = "bottled water", ProductCount = 10 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Beverage", ProductName = "Soda", ProductCount = 10 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Food", ProductName = "Sandwich", ProductCount = 55 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Snack", ProductName = "twinkie", ProductCount = 20 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Food", ProductName = "Soup", ProductCount = 45 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Snack", ProductName = "Chocolate", ProductCount = 90 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Snack", ProductName = "Butterfinger", ProductCount = 55 });
            response.Add(new Inventory() { WarehouseId = 2, WarehouseName = "Charlotte", ProductCategoryName = "Beverage", ProductName = "Soda", ProductCount = 20 });
            response.Add(new Inventory() { WarehouseId = 2, WarehouseName = "Charlotte", ProductCategoryName = "Beverage", ProductName = "bottled water", ProductCount = 20 });
            response.Add(new Inventory() { WarehouseId = 3, WarehouseName = "Ft Lauderdale", ProductCategoryName = "Beverage", ProductName = "sparkling water", ProductCount = 100 });
            response.Add(new Inventory() { WarehouseId = 3, WarehouseName = "Ft Lauderdale", ProductCategoryName = "Food", ProductName = "Sandwich", ProductCount = 40 });
            response.Add(new Inventory() { WarehouseId = 4, WarehouseName = "Nashville", ProductCategoryName = "Beverage", ProductName = "lemonade", ProductCount = 15 });
            response.Add(new Inventory() { WarehouseId = 4, WarehouseName = "Nashville", ProductCategoryName = "Food", ProductName = "Sandwich", ProductCount = 35 });
            response.Add(new Inventory() { WarehouseId = 4, WarehouseName = "Nashville", ProductCategoryName = "Snack", ProductName = "Butterfinger", ProductCount = 55 });

            return response;
        }
    }
}
