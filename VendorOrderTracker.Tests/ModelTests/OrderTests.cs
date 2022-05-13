using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Sourdough", "Sliced loaf", 1, 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void Cost_CalculatesTheCostOfTheOrderBasedOnUnitPrice_Int()
    {
      Order newOrder = new Order("Sourdough", "Sliced loaf", 1, 5);
      int price = newOrder.CalcCost();

      Assert.AreEqual(5, price);
    }
  }

}