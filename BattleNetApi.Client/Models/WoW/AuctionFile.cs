using System.Threading.Tasks;
using BattleNetApi.Client.Networking;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionFile
    {
        [JsonProperty(propertyName: "url")]
        public string Url { get; set; }
        [JsonProperty(propertyName: "lastModified")]
        public long LastModified { get; set; }

        public Task<AuctionDataFile> AuctionDataTask { get; set; }

        private AuctionDataFile _auctionDataFile;
        /// <summary>
        /// Gets the auction data from the url provided.
        /// This is done in a separate task via lazy loading.
        /// </summary>
        [JsonIgnore]
        public AuctionDataFile AuctionData => AuctionDataTask == null ? null : _auctionDataFile ?? (_auctionDataFile = AuctionDataDownloadManager.Enqueue(this).Result);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="auctionDataTask"></param>
        public AuctionFile(Task<AuctionDataFile> auctionDataTask = null)
        {
            AuctionDataTask = auctionDataTask;
        }
    }
}