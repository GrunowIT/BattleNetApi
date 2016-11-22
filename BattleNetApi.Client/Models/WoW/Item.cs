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
    public class Item : IApiEndpoint
    {
        [JsonProperty("bonusStats")]
        public ItemStat[] BonusStats { get; set; }
        [JsonProperty("bonusSummary")]
        public BonusSummary BonusSummary { get; set; }
        [JsonProperty("gemInfo")]
        public GemInfo GemInfo { get; set; }
        [JsonProperty("itemSource")]
        public ItemSource ItemSource { get; set; }
        [JsonProperty("itemSpells")]
        public ItemSpell[] ItemSpells { get; set; }
        [JsonProperty("socketInfo")]
        public SocketInfo SocketInfo { get; set; }
        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }
        [JsonProperty("equippable")]
        public bool Equippable { get; set; }
        [JsonProperty("hasSockets")]
        public bool HasSockets { get; set; }
        [JsonProperty("heroicTooltip")]
        public bool HeroicTooltip { get; set; }
        [JsonProperty("isAuctionable")]
        public bool IsAuctionable { get; set; }
        [JsonProperty("upgradable")]
        public bool Upgradable { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
        [JsonProperty("baseArmor")]
        public int BaseArmor { get; set; }
        [JsonProperty("buyPrice")]
        public int BuyPrice { get; set; }
        [JsonProperty("containerSlots")]
        public int ContainerSlots { get; set; }
        [JsonProperty("disenchantingSkillRank")]
        public int DisenchantingSkillRank { get; set; }
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("inventoryType")]
        public int InventoryType { get; set; }
        [JsonProperty("itemBind")]
        public int ItemBind { get; set; }
        [JsonProperty("itemClass")]
        public int ItemClass { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("itemSubClass")]
        public int ItemSubClass { get; set; }
        [JsonProperty("maxCount")]
        public int MaxCount { get; set; }
        [JsonProperty("maxDurability")]
        public int MaxDurability { get; set; }
        [JsonProperty("minFactionId")]
        public int MinFactionId { get; set; }
        [JsonProperty("minReputation")]
        public int MinReputation { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("requiredLevel")]
        public int RequiredLevel { get; set; }
        [JsonProperty("requiredSkill")]
        public int RequiredSkill { get; set; }
        [JsonProperty("requiredSkillRank")]
        public int RequiredSkillRank { get; set; }
        [JsonProperty("sellPrice")]
        public int SellPrice { get; set; }
        [JsonProperty("stackable")]
        public int Stackable { get; set; }
        [JsonProperty("bonusLists")]
        public int[] BonusLists { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameDescription")]
        public string NameDescription { get; set; }
        [JsonProperty("nameDescriptionColor")]
        public string NameDescriptionColor { get; set; }
        [JsonProperty("availableContexts")]
        public string[] AvailableContexts { get; set; }
    }
}
