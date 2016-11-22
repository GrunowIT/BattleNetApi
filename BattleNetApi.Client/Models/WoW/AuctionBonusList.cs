using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionBonusList
    {
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }
    }
}