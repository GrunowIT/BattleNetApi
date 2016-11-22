using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Networking;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public Item GetItem(int itemId)
        {
            var apiRequest = new ApiRequest<Item>(GetEndpointUri($"/wow/item/{itemId}"));
            return GetApiResponse(apiRequest);
        }

        public ItemSet GetItemSet(int setId)
        {
            var apiRequest = new ApiRequest<ItemSet>(GetEndpointUri($"/wow/item/set/{setId}"));
            return GetApiResponse(apiRequest);
        }
    }
}
