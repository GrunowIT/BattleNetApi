using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AchievementCriterion
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("orderIndex")]
        public int OrderIndex { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
    }
}