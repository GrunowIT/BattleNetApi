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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.D3
{
    public class ItemInfo : ItemInfoBase, IApiEndpoint
    {
        [JsonProperty("requiredLevel")]
        public int RequiredLevel { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("stackSizeMax")]
        public int StackSizeMax { get; set; }
        [JsonProperty("bonusAffixes")]
        public int BonusAffixes { get; set; }
        [JsonProperty("bonusAffixesMax")]
        public int BonusAffixesMax { get; set; }
        [JsonProperty("accountBound")]
        public bool AccountBound { get; set; }
        [JsonProperty("flavorText")]
        public string FlavorText { get; set; }
        [JsonProperty("typeName")]
        public string TypeName { get; set; }
        [JsonProperty("type")]
        public ItemType Type { get; set; }
        [JsonProperty("damageRange")]
        public string DamageRange { get; set; }
        [JsonProperty("dps")]
        public StatsInfoMinMax Dps { get; set; }
        [JsonProperty("attacksPerSecond")]
        public StatsInfoMinMax AttacksPerSecond { get; set; }
        [JsonProperty("attacksPerSecondText")]
        public string AttacksPerSecondText { get; set; }
        [JsonProperty("minDamage")]
        public StatsInfoMinMax MinDamage { get; set; }
        [JsonProperty("maxDamage")]
        public StatsInfoMinMax MaxDamage { get; set; }
        [JsonProperty("elementalType")]
        public string ElementalType { get; set; }
        [JsonProperty("armor")]
        public StatsInfoMinMax Armor { get; set; }
        [JsonProperty("slots")]
        public string[] Slots { get; set; }
        [JsonProperty("attributes")]
        public ItemAttributes Attributes { get; set; }
        [JsonProperty("attributesRaw")]
        public Dictionary<string, StatsInfoMinMax> AttributesRaw { get; set; }
        [JsonProperty("randomAffixes")]
        public RandomAffix[] RandomAffixes { get; set; }
        [JsonProperty("gems")]
        public Gem[] Gems { get; set; }

        /// <summary>
        /// Data structure yet unknown.
        /// </summary>
        [JsonProperty("socketEffects")]
        public object[] SocketEffects { get; set; }
        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }
        [JsonProperty("craftedBy")]
        public CraftedBy[] CraftedBy { get; set; }
        [JsonProperty("seasonRequiredToDrop")]
        public int SeasonRequiredToDrop { get; set; }
        [JsonProperty("isSeasonRequiredToDrop")]
        public bool IsSeasonRequiredToDrop { get; set; }
        [JsonProperty("description")]
        public object Description { get; set; }
        [JsonProperty("blockChance")]
        public string BlockChance { get; set; }
    }
}
