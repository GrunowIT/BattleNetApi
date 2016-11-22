using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AchievementReward
    {
        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }

        [JsonProperty(propertyName: "name")]
        public string Description { get; set; }

        [JsonProperty(propertyName: "icon")]
        public string Icon { get; set; }

        [JsonProperty(propertyName: "quality")]
        public int Quality { get; set; }

        [JsonProperty(propertyName: "tooltipParams")]
        public AchievementRewardTooltipParameters TooltipParams { get; set; }
    }
}
