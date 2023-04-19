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
  }
}