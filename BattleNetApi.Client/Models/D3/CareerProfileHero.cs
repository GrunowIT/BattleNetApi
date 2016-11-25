using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.D3
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CareerProfileHero
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("gender")]
        public int Gender { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("kills")]
        public Kills Kills { get; set; }
        [JsonProperty("paragonLevel")]
        public int ParagonLevel { get; set; }
        [JsonProperty("hardcore")]
        public bool Hardcore { get; set; }
        [JsonProperty("seasonal")]
        public bool Seasonal { get; set; }
        [JsonProperty("progression")]
        public ActCompletionInfo Progression { get; set; }
        [JsonProperty("dead")]
        public bool Dead { get; set; }
        [JsonProperty("lastupdated")]
        public int LastUpdated { get; set; }
    }
}
