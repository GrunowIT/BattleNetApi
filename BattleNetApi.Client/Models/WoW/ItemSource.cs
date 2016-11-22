using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSource
    {
        [JsonProperty("sourceId")]
        public int SourceId { get; set; }
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }
    }
}