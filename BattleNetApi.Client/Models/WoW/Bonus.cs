using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
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
}