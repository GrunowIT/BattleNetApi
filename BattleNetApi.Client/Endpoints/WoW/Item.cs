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
namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient
    {
        private static string GetItemUrl(int itemId)
        {
            return $"/wow/item/{itemId}";
        }
        private static string GetItemSetUrl(int setId)
        {
            return $"/wow/item/set/{setId}";
        }

        public Item GetItem(int itemId)
        {
            return GetApiResponse(ForgeApiRequest<Item>(GetItemUrl(itemId)));
        }

        public async Task<Item> GetItemAsync(int itemId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<Item>(GetItemUrl(itemId)));
        }

        public ItemSet GetItemSet(int setId)
        {
            return GetApiResponse(ForgeApiRequest<ItemSet>(GetItemSetUrl(setId)));
        }

        public async Task<ItemSet> GetItemSetAsync(int setId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<ItemSet>(GetItemSetUrl(setId)));
        }
    }
}
