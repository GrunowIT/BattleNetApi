using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSetBonus
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("threshold")]
        public int Threshold { get; set; }
    }
}