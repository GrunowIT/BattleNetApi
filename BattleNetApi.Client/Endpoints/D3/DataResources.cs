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
using BattleNetApi.Client.Models.D3;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client
{
    public partial class D3ApiClient
    {
        private static string GetDataBaseUrl = "/d3/data/";

        private static string GetDataItemInfoUrl(string itemId)
        {
            return GetDataBaseUrl + $"item/{itemId}";
        }

        public ItemInfo GetDataItemInfo(string itemId)
        {
            return GetApiResponse(ForgeApiRequest<ItemInfo>(GetDataItemInfoUrl(itemId)));
        }

        public async Task<ItemInfo> GetDataItemInfoAsync(string itemId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<ItemInfo>(GetDataItemInfoUrl(itemId)));
        }
    }
}
