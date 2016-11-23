using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public static string GetRecipeUrl(int id)
        {
            return $"/wow/recipe/{id}";
        }

        public Recipe GetRecipe(int id)
        {
            return GetApiResponse(ForgeApiRequest<Recipe>(GetRecipeUrl(id)));
        }

        public async Task<Recipe> GetRecipeAsync(int id)
        {
            return await GetApiResponseAsync(ForgeApiRequest<Recipe>(GetRecipeUrl(id)));
        }
    }
}
