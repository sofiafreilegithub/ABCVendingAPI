using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RushCodeExercise.Models;

namespace RushCodeExercise.Providers
{
    public interface IWarehouseInventoryProvider
    {
        List<Inventory> GetWarehouseInventoryByUserId(int userId);

        List<Inventory> UpdateWarehouseInventory(int units);
    }
}
