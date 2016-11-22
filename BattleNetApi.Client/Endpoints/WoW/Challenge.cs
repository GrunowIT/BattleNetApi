using System.Web;
using BattleNetApi.Client.Models.WoW;

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
            return GetApiResponse(ForgeApiRequest<ChallengeList>($"/wow/challenge/{HttpUtility.UrlEncode(realm)}"));
        }
    }
}
