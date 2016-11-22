using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PvpArenaInfo
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("weeklyPlayed")]
        public int WeeklyPlayed { get; set; }
        [JsonProperty("weeklyWon")]
        public int WeeklyWon { get; set; }
        [JsonProperty("weeklyLost")]
        public int WeeklyLost { get; set; }
        [JsonProperty("seasonPlayed")]
        public int SeasonPlayed { get; set; }
        [JsonProperty("seasonWon")]
        public int SeasonWon { get; set; }
        [JsonProperty("seasonLost")]
        public int SeasonLost { get; set; }
    }
}