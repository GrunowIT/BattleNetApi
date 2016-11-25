using System.Threading.Tasks;
using System.Web;
using BattleNetApi.Client.Models.D3;

namespace BattleNetApi.Client
{
    public partial class D3ApiClient
    {
        private static string GetCareerProfileUrl(string battleTag)
        {
            return $"/d3/profile/{HttpUtility.UrlEncode(battleTag)}/";
        }

        private static string GetHeroProfileUrl(string battleTag, int heroId)
        {
            return GetCareerProfileUrl(battleTag) + $"hero/{heroId}";
        }

        #region Career Profile
        public CareerProfile GetCareerProfile(string battleTag)
        {
            return GetApiResponse(ForgeApiRequest<CareerProfile>(GetCareerProfileUrl(battleTag)));
        }

        public async Task<CareerProfile> GetCareerProfileAsync(string battleTag)
        {
            return await GetApiResponseAsync(ForgeApiRequest<CareerProfile>(GetCareerProfileUrl(battleTag)));
        }
        #endregion

        #region Hero Profile
        public Hero GetHeroProfile(string battleTag, int heroId)
        {
            return GetApiResponse(ForgeApiRequest<Hero>(GetHeroProfileUrl(battleTag, heroId)));
        }

        public async Task<Hero> GetHeroProfileAsync(string battleTag, int heroId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<Hero>(GetHeroProfileUrl(battleTag, heroId)));
        }
        #endregion
    }
}
