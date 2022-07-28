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
            var response = new List<Inventory>();
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Beverage", ProductName = "sparkling water", ProductCount = 125 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Food", ProductName = "Ham/Cheese Sandwich", ProductCount = 456 });
            response.Add(new Inventory() { WarehouseId = 1, WarehouseName = "San Antonio", ProductCategoryName = "Snack", ProductName = "twinkie", ProductCount = 131 });
            response.Add(new Inventory() { WarehouseId = 2, WarehouseName = "Charlotte", ProductCategoryName = "Beverage", ProductName = "Soda", ProductCount = 321 });
            response.Add(new Inventory() { WarehouseId = 2, WarehouseName = "Charlotte", ProductCategoryName = "Beverage", ProductName = "bottled Water", ProductCount = 211 });
            response.Add(new Inventory() { WarehouseId = 3, WarehouseName = "Ft Lauderdale", ProductCategoryName = "Beverage", ProductName = "sparkling water", ProductCount = 100 });
            response.Add(new Inventory() { WarehouseId = 3, WarehouseName = "Ft Lauderdale", ProductCategoryName = "Food", ProductName = "Ham/Cheese Sandwich", ProductCount = 142 });
            response.Add(new Inventory() { WarehouseId = 4, WarehouseName = "Nashville", ProductCategoryName = "Beverage", ProductName = "lemonade", ProductCount = 157 });
            response.Add(new Inventory() { WarehouseId = 4, WarehouseName = "Nashville", ProductCategoryName = "Food", ProductName = "bacon/egg Sandwich", ProductCount = 134 });

            return response;
        }
    }
}
