using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RaidBossProgression
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("normalKills")]
        public int NormalKills { get; set; }
        [JsonProperty("normalTimestamp")]
        public long NormalTimestamp { get; set; }
        [JsonProperty("heroicKills")]
        public int HeroicKills { get; set; }
        [JsonProperty("heroicTimestamp")]
        public int HeroicTimestamp { get; set; }
        [JsonProperty("lfrKills")]
        public int LfrKills { get; set; }
        [JsonProperty("lfrTimestamp")]
        public long LfrTimestamp { get; set; }
        [JsonProperty("mythicKills")]
        public int MythicKills { get; set; }
        [JsonProperty("mythicTimestamp")]
        public int MythicTimestamp { get; set; }
    }
}