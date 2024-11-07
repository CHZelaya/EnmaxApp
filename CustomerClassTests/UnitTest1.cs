// ************************************************************************************
// SAIT Class: Fall 2024 RAD for OOSD (CRPG-200-A)
// Author: Carlos Hernandez-Zelaya
// Project Title: CPRG 200 Lab Assignment 2
// ************************************************************************************
namespace EnmaxApp.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculateCharge_WithZeroKwh()
        {
            // Method should still return the base $12 admin fee, despite 0 kWh's being reported.
            // Arrange
            var kwhUsed = 0;
            var customer = new Customer("Rick", "Sanchez", kwhUsed, 0m);

            // Act
            var charge = customer.CalculateCharge();

            // Assert
            Assert.AreEqual(12.0, charge, "Charge should be the base fee when kWh used is zero.");
        }

        [TestMethod]
        public void CalculateCharge_WithPositiveKwh()
        {
            //Testing the method in its intended purpose, with positive kWh hours + admin fee.
            // Arrange
            var kwhUsed = 10.0;
            var customer = new Customer("Morty", "Smith", kwhUsed, 0m);

            // Act
            var charge = customer.CalculateCharge();

            // Assert
            // Calculate expected charge based on kWh
            var expectedCharge = (kwhUsed * 0.07) + 12;
            Assert.AreEqual(expectedCharge, charge, "Charge calculation is incorrect.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateCharge_WithNegativeKwH()
        {
            //Testing method with negative kWh's reported, should throw an argument exception.
            //Arrange
            var kwhUsed = -10.0;
            var customer = new Customer("Evil", "Morty", kwhUsed, 0m);

            //Act
            customer.CalculateCharge(); // Expecting to see an exception.
            // No Assert needed.
        }

    }
}