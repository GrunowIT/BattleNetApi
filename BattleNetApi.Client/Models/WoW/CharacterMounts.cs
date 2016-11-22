using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterMounts
    {
        [JsonProperty("numCollected")]
        public int NumCollected { get; set; }
        [JsonProperty("numNotCollected")]
        public int NumNotCollected { get; set; }
        [JsonProperty("collected")]
        public CollectedMountInfo[] CollectedMounts { get; set; }
    }
}