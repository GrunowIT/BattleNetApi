using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterPvp
    {
        [JsonProperty("brackets")]
        public PvpBrackets Brackets { get; set; }
    }
}