using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Professions
    {
        [JsonProperty("primary")]
        public ProfessionInfo[] Primary { get; set; }
        [JsonProperty("secondary")]
        public ProfessionInfo[] Secondary { get; set; }
    }
}