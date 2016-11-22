using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Networking;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public Achievement GetAchievement(int id)
        {
            var apiRequest = new ApiRequest<Achievement>(GetEndpointUri($"/wow/achievement/{id}"));
            return GetApiResponse(apiRequest);
        }
    }
}
