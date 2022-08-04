using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using RushCodeExercise.Models;
using RushCodeExercise.Providers;

namespace RushCodeExercise.Controllers
{
    //[Route("api/[controller]")]
    [EnableCors("AnyOrigin")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        protected IWarehouseInventoryProvider Provider;

        public InventoryController(IWarehouseInventoryProvider provider)
        {
            Provider = provider;
        }

        [HttpGet("api/inventory")]
        public ActionResult<IEnumerable<Inventory>> GetWarehouseInventory()
        {
            var response = Provider.GetWarehouseInventoryByUserId(1);

            return new OkObjectResult(response);
        }

        [HttpGet("api/updateinventory/{warehouseId}/{productName}/{updatedUnitCount}")]
        public ActionResult<IEnumerable<Inventory>> UpdateInventory([FromRoute] int warehouseId, string productName, int updatedUnitCount)
        {
            var response = Provider.UpdateWarehouseInventory(warehouseId, productName, updatedUnitCount);

            return new OkObjectResult(response);
        }
    }
}

