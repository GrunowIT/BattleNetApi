using BattleNetApi.Client.Models.WoW;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public RealmList GetRealmStatusList()
        {
            return GetApiResponse(ForgeApiRequest<RealmList>("/wow/realm/status"));
        }
    }
}
