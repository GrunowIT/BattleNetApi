using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionDataFile : IApiEndpoint
    {
        [JsonProperty(propertyName: "realms")]
        public Realm[] Realms { get; set; }
        [JsonProperty(propertyName: "auctions")]
        public Auction[] Auctions { get; set; }
    }
}