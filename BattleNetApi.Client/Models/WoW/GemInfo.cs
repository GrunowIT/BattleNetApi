using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GemInfo
    {
        [JsonProperty("bonus")]
        public Bonus Bonus { get; set; }
        [JsonProperty("type")]
        public GemType Type { get; set; }
        [JsonProperty("minItemLevel")]
        public int MinItemLevel { get; set; }
    }
}