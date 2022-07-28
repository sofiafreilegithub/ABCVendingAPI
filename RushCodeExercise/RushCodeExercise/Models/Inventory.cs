using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RushCodeExercise.Models
{
    public class Inventory
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public int LocationId { get; set; }
    }
}
