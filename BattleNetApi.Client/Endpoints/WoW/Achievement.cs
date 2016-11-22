using BattleNetApi.Client.Models.WoW;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public Achievement GetAchievement(int id)
        {
            return GetApiResponse(ForgeApiRequest<Achievement>($"/wow/achievement/{id}"));
        }
    }
}
