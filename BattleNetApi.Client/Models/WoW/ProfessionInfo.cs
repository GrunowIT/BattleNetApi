using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ProfessionInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
        [JsonProperty("recipes")]
        public int?[] Recipes { get; set; }
    }
}