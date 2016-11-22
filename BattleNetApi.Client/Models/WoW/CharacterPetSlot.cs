using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterPetSlot
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }
        [JsonProperty("isEmpty")]
        public bool IsEmpty { get; set; }
        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }
        [JsonProperty("abilities")]
        public int[] Abilities { get; set; }
    }
}