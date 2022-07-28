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
            return response;
        }

        public List<Inventory> UpdateWarehouseInventory(int units)
        {
            var currentInventory = Service.GetWarehouseInventory();
            currentInventory.ForEach(x => x.ProductCount = x.ProductCount - units);

            return currentInventory;

        }
    }
}
