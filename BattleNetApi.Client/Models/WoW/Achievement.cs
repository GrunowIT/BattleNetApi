using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Achievement : IApiEndpoint
    {
        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }

        [JsonProperty(propertyName: "title")]
        public string Title { get; set; }

        [JsonProperty(propertyName: "points")]
        public int Points { get; set; }
        
        [JsonProperty(propertyName: "description")]
        public string Description { get; set; }

        [JsonProperty(propertyName: "reward")]
        public string Reward { get; set; }

        [JsonProperty(propertyName: "icon")]
        public string Icon { get; set; }

        [JsonProperty(propertyName: "accountWide")]
        public bool AccountWide { get; set; }

        [JsonProperty(propertyName: "rewardItems")]
        public IEnumerable<AchievementReward> RewardItems { get; set; }

        [JsonProperty(propertyName: "criteria")]
        public IEnumerable<AchievementCriteria> Criteria { get; set; }
    }
}
