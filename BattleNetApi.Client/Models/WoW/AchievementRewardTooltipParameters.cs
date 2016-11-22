using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    public class AchievementRewardTooltipParameters
    {
        [JsonProperty(propertyName: "gem0")]
        public int Gem0 { get; set; }

        [JsonProperty(propertyName: "gem1")]
        public int Gem1 { get; set; }

        [JsonProperty(propertyName: "gem2")]
        public int Gem2 { get; set; }

        [JsonProperty(propertyName: "enchant")]
        public int Enchant { get; set; }

        [JsonProperty(propertyName: "reforge")]
        public int Reforge { get; set; }

        [JsonProperty(propertyName: "set")]
        public IEnumerable<int> @Set { get; set; }

        [JsonProperty(propertyName: "seed")]
        public long Seed { get; set; }

        [JsonProperty(propertyName: "extraSocket")]
        public bool ExtraSocket { get; set; }

        [JsonProperty(propertyName: "suffix")]
        public int Suffix { get; set; }

        [JsonProperty(propertyName: "upgrade")]
        public ItemLevelUpgrade ItemLevelUpgrade { get; set; }
    }
}
