using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeSilverCriteria
    {
        [JsonProperty("time")]
        public int Time { get; set; }
        [JsonProperty("hours")]
        public int Hours { get; set; }
        [JsonProperty("minutes")]
        public int Minutes { get; set; }
        [JsonProperty("seconds")]
        public int Seconds { get; set; }
        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }
}