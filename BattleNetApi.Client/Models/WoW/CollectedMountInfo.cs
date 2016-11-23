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

using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CollectedMountInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("qualityId")]
        public int QualityId { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("isGround")]
        public bool IsGround { get; set; }
        [JsonProperty("isFlying")]
        public bool IsFlying { get; set; }
        [JsonProperty("isAquatic")]
        public bool IsAquatic { get; set; }
        [JsonProperty("isJumping")]
        public bool IsJumping { get; set; }
    }
}