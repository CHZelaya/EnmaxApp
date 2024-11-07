namespace EnmaxApp.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        // Testing to see that CalculateCharge method still adds the $12 admin fee despite being given '0' kWh.
        public void CalculateCharge_WithZerokWh()
        {
            //arrange
            var customer = new Customer("John", "Doe", 0, 0m);
            //act
            var charge = customer.CalculateCharge();
            //assert
            Assert.AreEqual(12.0, charge, "Charge should be the base fee when kWh used is zero");
        }
    }
}