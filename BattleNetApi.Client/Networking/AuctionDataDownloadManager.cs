using System;
using System.Threading;
using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Utilities;

namespace BattleNetApi.Client.Networking
{
    public static class AuctionDataDownloadManager
    {
        // TODO: Make configurable.
        private static readonly TimeThrottledQueue Queue = new TimeThrottledQueue(5, TimeSpan.FromSeconds(1));

        public static Task<AuctionDataFile> Enqueue(AuctionFile auctionFile)
        {
            return Queue.Enqueue(() => ApiProvider.GetFromJson(new ApiRequest<AuctionDataFile>(new Uri(auctionFile.Url))), CancellationToken.None);
        }
    }
}
