using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BossList
    {
        [JsonProperty("bosses")]
        public Boss[] Bosses { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Boss
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("zoneId")]
        public int ZoneId { get; set; }
        [JsonProperty("availableInNormalMode")]
        public bool AvailableInNormalMode { get; set; }
        [JsonProperty("availableInHeroicMode")]
        public bool AvailableInHeroicMode { get; set; }
        [JsonProperty("health")]
        public int Health { get; set; }
        [JsonProperty("heroicHealth")]
        public int HeroicHealth { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("heroicLevel")]
        public int HeroicLevel { get; set; }
        [JsonProperty("journalId")]
        public int JournalId { get; set; }
        [JsonProperty("npcs")]
        public BossNpc[] BossNpcs { get; set; }
        [JsonProperty("location")]
        public BossLocation BossLocation { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class BossLocation
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class BossNpc
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
    }

}
