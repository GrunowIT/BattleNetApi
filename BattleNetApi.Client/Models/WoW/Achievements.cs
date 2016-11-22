using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Achievements
    {
        [JsonProperty("achievementsCompleted")]
        public int[] AchievementsCompleted { get; set; }
        [JsonProperty("achievementsCompletedTimestamp")]
        public long[] AchievementsCompletedTimestamp { get; set; }
        [JsonProperty("criteria")]
        public int[] Criteria { get; set; }
        [JsonProperty("criteriaQuantity")]
        public long[] CriteriaQuantity { get; set; }
        [JsonProperty("criteriaTimestamp")]
        public long[] CriteriaTimestamp { get; set; }
        [JsonProperty("criteriaCreated")]
        public long[] CriteriaCreated { get; set; }
    }
}