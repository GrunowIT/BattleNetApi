using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterPets
    {
        [JsonProperty("numCollected")]
        public int NumCollected { get; set; }
        [JsonProperty("numNotCollected")]
        public int NumNotCollected { get; set; }
        [JsonProperty("collected")]
        public CollectedPetInfo[] CollectedPets { get; set; }
    }
}