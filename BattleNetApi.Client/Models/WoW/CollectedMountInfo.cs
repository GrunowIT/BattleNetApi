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