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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleNetApi.Client.Constants;

namespace BattleNetApi.Client.Extensions.Tests
{
    [TestClass()]
    public class FieldsEnumExtensionsTests
    {
        [TestMethod()]
        public void GetFieldsAsStringsCharacterTest()
        {
            var characterFields = CharacterFields.Achievements | CharacterFields.Appearance | CharacterFields.Feed;

            var strings = characterFields.GetFieldsAsStrings();
            
            Assert.IsNotNull(strings);
            Assert.AreEqual(3, strings.Count());
            Assert.IsTrue(strings.Contains("achievements"));
            Assert.IsTrue(strings.Contains("appearance"));
            Assert.IsTrue(strings.Contains("feed"));
        }

        [TestMethod()]
        public void GetFieldsAsStringsGuildTest()
        {
            var guildFields = GuildFields.Achievements | GuildFields.Members | GuildFields.Challenge;

            var strings = guildFields.GetFieldsAsStrings();

            Assert.IsNotNull(strings);
            Assert.AreEqual(3, strings.Count());
            Assert.IsTrue(strings.Contains("achievements"));
            Assert.IsTrue(strings.Contains("members"));
            Assert.IsTrue(strings.Contains("challenge"));
        }
    }
}