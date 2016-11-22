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
            var apiRequest = new ApiRequest<AuctionResponse>(GetEndpointUri($"/wow/auction/data/{HttpUtility.UrlEncode(realm)}"));
            var result = GetApiResponse(apiRequest);

            // Setup lazy loading tasks.
            foreach (var auctionFile in result.AuctionFiles)
            {
                auctionFile.AuctionDataTask = new Task<AuctionDataFile>(() =>
                {
                    var apiResponse = ApiProvider.GetFromJson(new ApiRequest<AuctionDataFile>(new Uri(auctionFile.Url)));
                    return apiResponse;
                });
            }

            return result;
        }
    }
}
