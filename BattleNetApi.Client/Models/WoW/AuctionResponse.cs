using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionResponse : IApiEndpoint
    {
        [JsonProperty(propertyName: "files")]
        public IEnumerable<AuctionFile> AuctionFiles { get; set; }
    }
}
