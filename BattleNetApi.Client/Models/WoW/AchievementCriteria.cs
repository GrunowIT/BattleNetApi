using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AchievementCriteria
    {
        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }

        [JsonProperty(propertyName: "description")]
        public string Description { get; set; }

        [JsonProperty(propertyName: "orderIndex")]
        public int OrderIndex { get; set; }

        [JsonProperty(propertyName: "max")]
        public int Max { get; set; }
    }
}
