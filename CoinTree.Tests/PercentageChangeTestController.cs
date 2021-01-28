using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinTree.Controllers;
using CoinTree.Helpers;
using CoinTree.Interfaces;

namespace CoinTree.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPostPercentageChange()
        {
            var controller = new PercentageChangeController(new CoinTreeWebClient(), new LoggerManager());
            var result = controller.PostPercentageChange(new Models.ChangePercentageInput() { CoinType = "BTC", OldPrice = 0 });

            Assert.IsNotNull(result);
        }
    }
}
