using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionModifier
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}