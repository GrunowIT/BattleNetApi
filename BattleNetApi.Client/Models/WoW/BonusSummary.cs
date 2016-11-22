using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BonusSummary
    {
        [JsonProperty("defaultBonusLists")]
        public object[] DefaultBonusLists { get; set; }
        [JsonProperty("chanceBonusLists")]
        public object[] ChanceBonusLists { get; set; }
        [JsonProperty("bonusChances")]
        public object[] BonusChances { get; set; }
    }
}