using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BossList
    {
        [JsonProperty("bosses")]
        public Boss[] Bosses { get; set; }
    }
}