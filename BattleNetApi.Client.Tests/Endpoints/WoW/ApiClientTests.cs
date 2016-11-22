using System.Configuration;
using System.Linq;
using BattleNetApi.Client.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleNetApi.Client.Tests
{
    [TestClass()]
    public class ApiClientTests
    {
        private static ApiClient GetApiClient => new ApiClient(ConfigurationManager.AppSettings["apikey"], Region.EU, Locale.de_DE);

        [TestMethod()]
        public void GetAchievementTest()
        {
            var achievement = GetApiClient.GetAchievement(2144);
            Assert.AreEqual(2144, achievement.Id);
        }

        [TestMethod()]
        public void GetAuctionDataTest()
        {
            var auctionResponse = GetApiClient.GetAuctionData("malganis");
            Assert.IsTrue(auctionResponse.AuctionFiles.Any(), "No auction files found.");
            var auctionFile = auctionResponse.AuctionFiles.First();
            Assert.IsTrue(auctionFile.AuctionData.Auctions.Any(), "No auctions found.");
        }
    }
}