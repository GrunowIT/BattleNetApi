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

using System;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ClassTalentsList : IApiEndpoint
    {
        [JsonProperty("1")]
        public ClassTalents Warrior { get; set; }
        [JsonProperty("2")]
        public ClassTalents Paladin { get; set; }
        [JsonProperty("3")]
        public ClassTalents Hunter { get; set; }
        [JsonProperty("4")]
        public ClassTalents Rogue { get; set; }
        [JsonProperty("5")]
        public ClassTalents Priest { get; set; }
        [JsonProperty("6")]
        public ClassTalents DeathKnight { get; set; }
        [JsonProperty("7")]
        public ClassTalents Shaman { get; set; }
        [JsonProperty("8")]
        public ClassTalents Mage { get; set; }
        [JsonProperty("9")]
        public ClassTalents Warlock { get; set; }
        [JsonProperty("10")]
        public ClassTalents Monk { get; set; }
        [JsonProperty("11")]
        public ClassTalents Druid { get; set; }
        [JsonProperty("12")]
        public ClassTalents DemonHunter { get; set; }

        /// <summary>
        /// Returns the <see cref="ClassTalents"/> for given class id.
        /// </summary>
        /// <param name="id">Class ID</param>
        /// <returns><see cref="ClassTalents"/></returns>
        public ClassTalents this[int id] => GetTalentsForClassId(id);

        /// <summary>
        /// Returns the <see cref="ClassTalents"/> for given class id.
        /// </summary>
        /// <param name="id">Class ID</param>
        /// <returns><see cref="ClassTalents"/></returns>
        public ClassTalents GetTalentsForClassId(int id)
        {
            switch (id)
            {
                case 1:
                    return Warrior;
                case 2:
                    return Paladin;
                case 3:
                    return Hunter;
                case 4:
                    return Rogue;
                case 5:
                    return Priest;
                case 6:
                    return DeathKnight;
                case 7:
                    return Shaman;
                case 8:
                    return Mage;
                case 9:
                    return Warlock;
                case 10:
                    return Monk;
                case 11:
                    return Druid;
                case 12:
                    return DemonHunter;
                default:
                    throw new ArgumentException("Unknown class id.");
            }
        }
    }
}
