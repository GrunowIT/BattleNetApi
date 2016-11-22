using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionDataFile : IApiEndpoint
    {
        [JsonProperty(propertyName: "realms")]
        public IEnumerable<Realm> Realms { get; set; }
        [JsonProperty(propertyName: "auctions")]
        public IEnumerable<Auction> Auctions { get; set; }
    }
}
