using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemLevelUpgrade
    {
        [JsonProperty("current")]
        public int Current { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("itemLevelIncrement")]
        public int ItemLevelIncrement { get; set; }
    }
}