using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PvpBrackets
    {
        [JsonProperty("ARENA_BRACKET_2v2")]
        public PvpArenaInfo ArenaBracket_2V2 { get; set; }
        [JsonProperty("ARENA_BRACKET_3v3")]
        public PvpArenaInfo ArenaBracket_3V3 { get; set; }
        [JsonProperty("ARENA_BRACKET_RBG")]
        public PvpArenaInfo ArenaBracketRbg { get; set; }
        [JsonProperty("ARENA_BRACKET_2v2_SKIRMISH")]
        public PvpArenaInfo ArenaBracket_2V2Skirmish { get; set; }
        [JsonProperty("UNKNOWN")]
        public PvpArenaInfo Unknown { get; set; }
    }
}