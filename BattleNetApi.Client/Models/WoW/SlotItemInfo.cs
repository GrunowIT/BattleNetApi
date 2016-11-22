using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SlotItemInfo
    {
        [JsonProperty("appearance")]
        public ItemAppearance Appearance { get; set; }
        [JsonProperty("artifactTraits")]
        public ArtifactTrait[] ArtifactTraits { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("artifactAppearanceId")]
        public int ArtifactAppearanceId { get; set; }
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("bonusLists")]
        public int[] BonusLists { get; set; }
        [JsonProperty("relics")]
        public Relic[] Relics { get; set; }
        [JsonProperty("stats")]
        public ItemStat[] Stats { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }
        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }
    }
}