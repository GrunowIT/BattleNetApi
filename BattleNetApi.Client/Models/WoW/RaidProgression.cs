using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RaidProgression
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("lfr")]
        public int Lfr { get; set; }
        [JsonProperty("normal")]
        public int Normal { get; set; }
        [JsonProperty("heroic")]
        public int Heroic { get; set; }
        [JsonProperty("mythic")]
        public int Mythic { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("bosses")]
        public RaidBossProgression[] Bosses { get; set; }
    }
}