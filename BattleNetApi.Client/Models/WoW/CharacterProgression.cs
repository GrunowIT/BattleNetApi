using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterProgression
    {
        [JsonProperty("raids")]
        public RaidProgression[] Raids { get; set; }
    }
}