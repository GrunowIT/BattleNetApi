using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemStat
    {
        [JsonProperty("stat")]
        public int Stat { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}