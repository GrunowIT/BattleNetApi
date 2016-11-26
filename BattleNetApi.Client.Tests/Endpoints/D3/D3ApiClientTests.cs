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
using BattleNetApi.Client.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleNetApi.Client.Tests
{
    [TestClass()]
    public class D3ApiClientTests
    {
        private static D3ApiClient D3ApiClient => new ApiClient(ConfigurationManager.AppSettings["apikey"], new ApiClientConfiguration(Region.EU, Locale.en_GB)).D3;

        [TestMethod()]
        public void GetCareerProfileTest()
        {
            var data = D3ApiClient.GetCareerProfile("Andy-2133");
            Assert.IsNotNull(data);
            Assert.AreEqual("Andy#2133", data.BattleTag);
        }

        [TestMethod()]
        public void GetHeroProfileTest()
        {
            var data = D3ApiClient.GetHeroProfile("Andy-2133", 38523201);
            Assert.IsNotNull(data);
            Assert.AreEqual(38523201, data.Id);
        }

        [TestMethod()]
        public void GetDataItemInfoTest()
        {
            var data = D3ApiClient.GetDataItemInfo("Unique_Boots_Set_10_x1");
            Assert.IsNotNull(data);
            Assert.AreEqual("Unique_Boots_Set_10_x1", data.Id);
        }
    }
}