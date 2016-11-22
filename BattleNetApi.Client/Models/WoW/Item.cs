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
        public Socketinfo SocketInfo { get; set; }
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

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSource
    {
        [JsonProperty("sourceId")]
        public int SourceId { get; set; }
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class BonusSummary
    {
        [JsonProperty("defaultBonusLists")]
        public object[] DefaultBonusLists { get; set; }
        [JsonProperty("chanceBonusLists")]
        public object[] ChanceBonusLists { get; set; }
        [JsonProperty("bonusChances")]
        public object[] BonusChances { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Socketinfo
    {
        [JsonProperty("sockets")]
        public Socket[] Sockets { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Socket
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSpell
    {
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
        [JsonProperty("spell")]
        public Spell Spell { get; set; }
        [JsonProperty("nCharges")]
        public int NCharges { get; set; }
        [JsonProperty("consumable")]
        public bool Consumable { get; set; }
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
        [JsonProperty("trigger")]
        public string Trigger { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Spell
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("castTime")]
        public string CastTime { get; set; }
        [JsonProperty("cooldown")]
        public string Cooldown { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class GemInfo
    {
        [JsonProperty("bonus")]
        public Bonus Bonus { get; set; }
        [JsonProperty("type")]
        public GemType Type { get; set; }
        [JsonProperty("minItemLevel")]
        public int MinItemLevel { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Bonus
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("srcItemId")]
        public int SrcItemId { get; set; }
        [JsonProperty("requiredSkillId")]
        public int RequiredSkillId { get; set; }
        [JsonProperty("requiredSkillRank")]
        public int RequiredSkillRank { get; set; }
        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class GemType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSet : IApiEndpoint
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("setBonuses")]
        public SetBonus[] SetBonuses { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class SetBonus
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("threshold")]
        public int Threshold { get; set; }
    }

}
