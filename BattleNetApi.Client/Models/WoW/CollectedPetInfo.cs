using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CollectedPetInfo
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
        [JsonProperty("stats")]
        public PetStats PetStats { get; set; }
        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }
        [JsonProperty("isFavorite")]
        public bool IsFavorite { get; set; }
        [JsonProperty("isFirstAbilitySlotSelected")]
        public bool IsFirstAbilitySlotSelected { get; set; }
        [JsonProperty("isSecondAbilitySlotSelected")]
        public bool IsSecondAbilitySlotSelected { get; set; }
        [JsonProperty("isThirdAbilitySlotSelected")]
        public bool IsThirdAbilitySlotSelected { get; set; }
        [JsonProperty("creatureName")]
        public string CreatureName { get; set; }
        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }
    }
}