/*
    BattleNetApi - A .NET battle.net API library.
    Copyright (C) 2016  Sebastian Grunow <sebastian@grunow-it.de>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    */

using System.Configuration;
using System.Linq;
using BattleNetApi.Client.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleNetApi.Client.Tests
{
    [TestClass()]
    public class ApiClientTests
    {
        private static WowApiClient WowApiClient => new ApiClient(ConfigurationManager.AppSettings["apikey"], new ApiClientConfiguration(Region.EU, Locale.en_GB)).WoW;

        [TestMethod()]
        public void GetAchievementTest()
        {
            var achievement = WowApiClient.GetAchievement(2144);
            Assert.IsNotNull(achievement);
            Assert.AreEqual(2144, achievement.Id);
        }

        [TestMethod()]
        public void GetAuctionDataTest()
        {
            var auctionResponse = WowApiClient.GetAuctionData("malganis");
            Assert.IsNotNull(auctionResponse);
            Assert.IsTrue(auctionResponse.AuctionFiles.Length > 0, "No auction files found.");
            var auctionFile = auctionResponse.AuctionFiles.First();
            Assert.IsTrue(auctionFile.AuctionData.Auctions.Length > 0, "No auctions found.");
        }

        [TestMethod()]
        public void GetRealmStatusListTest()
        {
            var realmList = WowApiClient.GetRealmStatusList();
            Assert.IsNotNull(realmList);
            Assert.IsTrue(realmList.Realms.Length > 0, "No realm found.");
            Assert.IsTrue(realmList.ConnectedRealms.Any(), "No connected realms found.");
            Assert.AreNotEqual(realmList.Realms.Count(), realmList.ConnectedRealms.Count(), 0, "Connected realms same count as realms count. (Might be correct)");
        }

        [TestMethod()]
        public void GetItemTest()
        {
            var item = WowApiClient.GetItem(18803);
            Assert.IsNotNull(item);
            Assert.AreEqual(18803, item.Id);
        }

        [TestMethod()]
        public void GetItemSetTest()
        {
            var itemSet = WowApiClient.GetItemSet(1060);
            Assert.IsNotNull(itemSet);
            Assert.AreEqual(1060, itemSet.Id, "Item id mismatch.");
            Assert.IsTrue(itemSet.Items.Length > 0, "No items found in set.");
        }

        [TestMethod()]
        public void GetChallengeRealmLeaderboardTest()
        {
            var leaderboard = WowApiClient.GetChallengeRealmLeaderboard("malganis");
            Assert.IsNotNull(leaderboard);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(leaderboard.Challenge[0].Realm.Name));
        }

        [TestMethod()]
        public void GetDataBattlegroupsTest()
        {
            var battlegroups = WowApiClient.GetDataBattlegroups();
            Assert.IsNotNull(battlegroups);
            Assert.IsTrue(battlegroups.Battlegroups.Length > 0);
        }

        [TestMethod()]
        public void GetDataCharacterRacesTest()
        {
            var races = WowApiClient.GetDataCharacterRaces();
            Assert.IsNotNull(races);
            Assert.IsTrue(races.Races.Length > 0);
        }

        [TestMethod()]
        public void GetDataCharacterClassesTest()
        {
            var classes = WowApiClient.GetDataCharacterClasses();
            Assert.IsNotNull(classes);
            Assert.IsTrue(classes.Classes.Length > 0);
        }

        [TestMethod()]
        public void GetDataCharacterAchievementsTest()
        {
            var data = WowApiClient.GetDataCharacterAchievements();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Achievements.Length > 0);
        }

        [TestMethod()]
        public void GetDataGuildRewardsTest()
        {
            var data = WowApiClient.GetDataGuildRewards();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Rewards.Length > 0);
        }

        [TestMethod()]
        public void GetDataGuildPerksTest()
        {
            var data = WowApiClient.GetDataGuildPerks();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Perks.Length > 0);
        }

        [TestMethod()]
        public void GetDataGuildAchievementesTest()
        {
            var data = WowApiClient.GetDataGuildAchievements();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Achievements.Length > 0);
        }

        [TestMethod()]
        public void GetDataItemClassesTest()
        {
            var data = WowApiClient.GetDataItemClasses();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Classes.Length > 0);
        }

        [TestMethod()]
        public void GetDataTalentsTest()
        {
            var data = WowApiClient.GetDataTalents();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Warrior.Talents.Length > 0);
            Assert.IsNotNull(data[1]);
            Assert.IsTrue(data[1].Talents.Length > 0);
        }

        [TestMethod()]
        public void GetDataPetTypesTest()
        {
            var data = WowApiClient.GetDataPetTypes();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.PetTypes.Length > 0);
        }

        [TestMethod()]
        public void GetBossListTest()
        {
            var data = WowApiClient.GetBossList();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Bosses.Length > 0);
        }

        [TestMethod()]
        public void GetBossTest()
        {
            var data = WowApiClient.GetBoss(24723);
            Assert.IsNotNull(data);
            Assert.AreEqual(24723, data.Id);
        }
    }
}