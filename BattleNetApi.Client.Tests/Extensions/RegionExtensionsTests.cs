using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleNetApi.Client.Constants;

namespace BattleNetApi.Client.Extensions.Tests
{
    [TestClass()]
    public class RegionExtensionsTests
    {
        [TestMethod()]
        public void GetBaseUrlTest()
        {
            var region = Region.EU;

            Assert.AreEqual("https://eu.api.battle.net", region.GetBaseUrl());
        }
    }
}