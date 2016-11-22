using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeMap
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("hasChallengeMode")]
        public bool HasChallengeMode { get; set; }
        [JsonProperty("bronzeCriteria")]
        public ChallengeBronzeCriteria BronzeCriteria { get; set; }
        [JsonProperty("silverCriteria")]
        public ChallengeSilverCriteria SilverCriteria { get; set; }
        [JsonProperty("goldCriteria")]
        public ChallengeGoldCriteria GoldCriteria { get; set; }
    }
}