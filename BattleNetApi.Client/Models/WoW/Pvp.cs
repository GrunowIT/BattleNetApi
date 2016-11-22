using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Pvp
    {
        [JsonProperty("brackets")]
        public PvpBrackets Brackets { get; set; }
    }
}