using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Networking;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public ChallengeList GetChallengeRealmLeaderboard(Realm realm)
        {
            return GetChallengeRealmLeaderboard(realm.Slug);
        }

        public ChallengeList GetChallengeRealmLeaderboard(string realm)
        {
            var apiRequest = new ApiRequest<ChallengeList>(GetEndpointUri($"/wow/challenge/{realm}"));
            return GetApiResponse(apiRequest);
        }
    }
}
