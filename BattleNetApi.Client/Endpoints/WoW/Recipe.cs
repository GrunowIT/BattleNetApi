/*
    BattleNetApi - A .NET battle.net API library.
    Copyright (C) 2016  Sebastian Grunow <sebastian@grunow-it.de>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    */

using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client
{
    public partial class WowApiClient
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
