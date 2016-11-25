using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient
    {
        public static string GetBossUrl(int id)
        {
            return $"/wow/boss/{id}";
        }
        public static string GetBossListUrl()
        {
            return "/wow/boss/";
        }

        public Boss GetBoss(int id)
        {
            return GetApiResponse(ForgeApiRequest<Boss>(GetBossUrl(id)));
        }

        public async Task<Boss> GetBossAsync(int id)
        {
            return await GetApiResponseAsync(ForgeApiRequest<Boss>(GetBossUrl(id)));
        }

        public BossList GetBossList()
        {
            return GetApiResponse(ForgeApiRequest<BossList>(GetBossListUrl()));
        }

        public async Task<BossList> GetBossListAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<BossList>(GetBossListUrl()));
        }
    }
}
