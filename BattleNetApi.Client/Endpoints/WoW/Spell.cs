using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient
    {
        public static string GetSpellUrl(int id)
        {
            return $"/wow/spell/{id}";
        }

        public Spell GetSpell(int id)
        {
            return GetApiResponse(ForgeApiRequest<Spell>(GetSpellUrl(id)));
        }

        public async Task<Spell> GetSpellAsync(int id)
        {
            return await GetApiResponseAsync(ForgeApiRequest<Spell>(GetSpellUrl(id)));
        }
    }
}
