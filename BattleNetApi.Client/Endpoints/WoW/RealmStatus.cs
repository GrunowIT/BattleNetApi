using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Networking;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public RealmList GetRealmStatusList()
        {
            var apiRequest = new ApiRequest<RealmList>(GetEndpointUri("/wow/realm/status"));
            return GetApiResponse(apiRequest);
        }
    }
}
