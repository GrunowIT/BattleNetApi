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

namespace BattleNetApi.Client.Extensions.Models.D3.Tests
{
    [TestClass()]
    public class ItemInfoBaseExtensionsTests
    {
        [TestMethod()]
        public void GetItemInfoFromTooltipParamsTest()
        {
            var api = new ApiClient(ConfigurationManager.AppSettings["apikey"], new ApiClientConfiguration(Region.EU, Locale.en_GB)).D3;
            var hero = api.GetHeroProfile("Andy-2133", 38523201);
            var firstItem = hero.Items.Values.FirstOrDefault(c => c != null);
            Assert.IsNotNull(firstItem);

            var detailedItemInfos = firstItem.GetItemInfoFromTooltipParams(api);

            Assert.IsNotNull(detailedItemInfos);
            Assert.AreEqual(firstItem.Id, detailedItemInfos.Id);
        }

        [TestMethod()]
        public void GetItemInfoFromTooltipParamsTest2()
        {
            var api = new ApiClient(ConfigurationManager.AppSettings["apikey"], new ApiClientConfiguration(Region.EU, Locale.en_GB)).D3;
            var item = api.GetDataItemInfo("Unique_Boots_Set_10_x1");
            Assert.IsNotNull(item);

            var detailedItemInfos = item.GetItemInfoFromTooltipParams(api);

            Assert.IsNotNull(detailedItemInfos);
            Assert.AreEqual(item.Id, detailedItemInfos.Id);
        }
    }
}