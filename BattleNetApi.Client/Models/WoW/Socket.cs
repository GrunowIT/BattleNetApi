using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Socket
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}