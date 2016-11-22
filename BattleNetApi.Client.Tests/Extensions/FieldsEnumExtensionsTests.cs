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