using Microsoft.VisualStudio.TestTools.UnitTesting;
using RushCodeExercise.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RushCodeExercise.Services;
using RushCodeExercise.Providers;
using RushCodeExercise.Models;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void GetWarehouseInventory()
        {
            //Arrange
            var warehouseProvider = new Mock<IWarehouseInventoryProvider>();

            warehouseProvider.Setup(x =>
                x.GetWarehouseInventoryByUserId(It.IsAny<int>()))
                .Returns(
                    new List<Inventory>() { new Inventory() { ProductName = "mockProduct", WarehouseName = "mockWarehouse"} }
                );

            var controller = new InventoryController(warehouseProvider.Object);

            ////Act
            var objResult = controller.GetWarehouseInventory();
            var response = (ObjectResult)objResult.Result;
            var statusCode = response.StatusCode;
            ////Assert
            Assert.IsTrue(statusCode==200);
        }


        [TestMethod]
        public void GetWarehouseInventoryByUserId()
        {
            //Arrange
            var warehouseService = new Mock<IWarehouseInventoryService>();

            warehouseService.Setup(x =>
                x.GetWarehouseInventory())
                .Returns(
                        new List<Inventory>() { new Inventory() { ProductName = "mockProduct", WarehouseName = "mockWarehouse" } }
                );


            var warehouseProvider = new WarehouseInventoryProvider(warehouseService.Object);

            ////Act
            var objResult = warehouseProvider.GetWarehouseInventoryByUserId(2);
            var response = objResult.ToArray();

            ////Assert
            Assert.AreEqual(response[0].ProductName, "mockProduct");

        }

        [TestMethod]
        public void GetUpdatedInventoryByUnits()
        {
            //Arrange
            var warehouseService = new Mock<IWarehouseInventoryService>();

            warehouseService.Setup(x =>
                x.GetWarehouseInventory())
                .Returns(
                        new List<Inventory>() { new Inventory() {
                            ProductName = "mockProductCountUpdate",
                            WarehouseName = "mockWarehouse",
                            ProductCategoryName = "mockCategory",
                            ProductCount = 55  //note count here
                        }
                });


            var warehouseProvider = new WarehouseInventoryProvider(warehouseService.Object);

            ////Act
            var objResult = warehouseProvider.UpdateWarehouseInventory(15);
            var response = objResult.ToArray();

            ////Assert
            Assert.AreEqual(response[0].ProductName, "mockProductCountUpdate");
            Assert.AreEqual(response[0].ProductCount, 40); //Note reduced count here

        }

    }
}