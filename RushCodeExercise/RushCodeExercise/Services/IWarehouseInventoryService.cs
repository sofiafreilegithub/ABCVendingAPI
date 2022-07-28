using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RushCodeExercise.Models;

namespace RushCodeExercise.Services
{
    public interface IWarehouseInventoryService
    {
        List<Inventory> GetWarehouseInventory();
    }
}
