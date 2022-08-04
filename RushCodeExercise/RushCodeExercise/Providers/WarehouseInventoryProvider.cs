using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RushCodeExercise.Models;
using RushCodeExercise.Services;

namespace RushCodeExercise.Providers
{
    public class WarehouseInventoryProvider : IWarehouseInventoryProvider
    {

        protected IWarehouseInventoryService Service;

        public WarehouseInventoryProvider(IWarehouseInventoryService service)
        {
            Service = service;
        }

        public List<Inventory> GetWarehouseInventoryByUserId(int userId)
        {
            var response = Service.GetWarehouseInventory();
            return OrderItems(response);
        }

        public List<Inventory> UpdateWarehouseInventory(int warehouseId, string productName, int updatedUnitCount)
        {
            var currentInventory = Service.GetWarehouseInventory();

            var productToUpdate = currentInventory.Where(p => p.WarehouseId == warehouseId && p.ProductName == productName).First();

            if (productToUpdate != null)
            {
                currentInventory.Remove(productToUpdate);
                currentInventory.Add(new Inventory()
                {
                    WarehouseId = warehouseId,
                    WarehouseName = productToUpdate.WarehouseName,
                    ProductCategoryName = productToUpdate.ProductCategoryName,
                    ProductName = productName,
                    ProductCount = updatedUnitCount
                });
            }

            return OrderItems(currentInventory);

        }

        private List<Inventory> OrderItems(List<Inventory> currentInventory)
        {
            return currentInventory.OrderBy(o => o.WarehouseId).ThenBy(o => o.ProductCategoryName).ToList();
        }
    }
}
