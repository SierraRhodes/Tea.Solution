using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeaShop.Models;

namespace Teas.Tests
{
  [TestClass]
  public class TeaTests
  {
    
    [TestMethod]
    public void TeaCreation_NewTea_GreenTea()
    {
      Tea testTea  = new Tea { Name = "Green Tea", Price = 2.99m };
    }

    [TestMethod]
    public void SetName_ValidName_SetName()
    {
    //Arrange 
    string expectedName = "Jasmine Tea";
    decimal expectedPrice = 2.99m;
    Tea testTea = new Tea { Name = "Green Tea", Price = 2.99m };

    //Act
    testTea.Name = expectedName;
    string actualName = testTea.Name;

    //Assert
    Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void SetPrice_ValidPrice_SetPrice()
    {
      //Arrange 
      string expectedName = "Jasmine Tea";
      decimal expectedPrice = 3.99m;
      Tea testTea = new Tea { Name = "Green Tea", Price = 2.99m };

      //Act
      testTea.Price = expectedPrice;
      decimal actualPrice = testTea.Price;

      //Assert
      Assert.AreEqual(expectedPrice, actualPrice);

    }
  }
}
