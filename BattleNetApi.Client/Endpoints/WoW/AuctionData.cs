using System;
using System.Threading.Tasks;
using System.Web;
using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Networking;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public AuctionResponse GetAuctionData(Realm realm)
        {
            return GetAuctionData(realm.Slug);
        }

        public AuctionResponse GetAuctionData(string realm)
        {
            var result = GetApiResponse(ForgeApiRequest<AuctionResponse>($"/wow/auction/data/{HttpUtility.UrlEncode(realm)}"));

            // Setup lazy loading tasks.
            foreach (var auctionFile in result.AuctionFiles)
            {
                auctionFile.AuctionDataTask = _getAuctionDataTask(auctionFile);
            }

            return result;
        }

        private Task<AuctionDataFile> _getAuctionDataTask(AuctionFile auctionFile)
        {
            return new Task<AuctionDataFile>(() =>
            {
                var apiResponse = ApiProvider.GetFromJson(new ApiRequest<AuctionDataFile>(new Uri(auctionFile.Url)));
                return apiResponse;
            });
        }
    }
}
