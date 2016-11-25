using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient
    {
        public static string GetZoneUrl(int id)
        {
            return $"/wow/zone/{id}";
        }
        public static string GetZoneListUrl()
        {
            return "/wow/zone/";
        }

        public Zone GetZone(int id)
        {
            return GetApiResponse(ForgeApiRequest<Zone>(GetZoneUrl(id)));
        }

        public async Task<Zone> GetZoneAsync(int id)
        {
            return await GetApiResponseAsync(ForgeApiRequest<Zone>(GetZoneUrl(id)));
        }

        public ZoneList GetZoneList()
        {
            return GetApiResponse(ForgeApiRequest<ZoneList>(GetZoneListUrl()));
        }

        public async Task<ZoneList> GetZoneListAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<ZoneList>(GetZoneListUrl()));
        }
    }
}
