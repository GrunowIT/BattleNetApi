using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HunterPet
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("creature")]
        public int Creature { get; set; }
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("spec")]
        public Spec Spec { get; set; }
        [JsonProperty("calcSpec")]
        public string CalcSpec { get; set; }
        [JsonProperty("familyId")]
        public int FamilyId { get; set; }
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }
}