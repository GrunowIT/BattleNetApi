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
        #region Url definitions
        private static string GetDataBaseUrl = "/d3/data/";

        private static string GetDataItemInfoUrl(string itemId)
        {
            return GetDataBaseUrl + $"item/{itemId}";
        }

        private static string GetDataFollowerInfoUrl(string followerId)
        {
            return GetDataBaseUrl + $"follower/{followerId}";
        }

        private static string GetDataArtisanInfoUrl(string artisanId)
        {
            return GetDataBaseUrl + $"artisan/{artisanId}";
        }
        #endregion

        public ItemInfo GetDataItemInfo(string itemId)
        {
            return GetApiResponse(ForgeApiRequest<ItemInfo>(GetDataItemInfoUrl(itemId)));
        }

        public async Task<ItemInfo> GetDataItemInfoAsync(string itemId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<ItemInfo>(GetDataItemInfoUrl(itemId)));
        }

        public FollowerInfo GetDataFollowerInfo(string followerId)
        {
            return GetApiResponse(ForgeApiRequest<FollowerInfo>(GetDataFollowerInfoUrl(followerId)));
        }

        public async Task<FollowerInfo> GetDataFollowerInfoAsync(string followerId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<FollowerInfo>(GetDataFollowerInfoUrl(followerId)));
        }

        public ArtisanInfo GetDataArtisanInfo(string artisanId)
        {
            return GetApiResponse(ForgeApiRequest<ArtisanInfo>(GetDataArtisanInfoUrl(artisanId)));
        }

        public async Task<ArtisanInfo> GetDataArtisanInfoAsync(string artisanId)
        {
            return await GetApiResponseAsync(ForgeApiRequest<ArtisanInfo>(GetDataArtisanInfoUrl(artisanId)));
        }
    }
}
