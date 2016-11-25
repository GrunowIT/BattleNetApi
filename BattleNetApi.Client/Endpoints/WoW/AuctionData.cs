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

using System;
using System.Threading.Tasks;
using System.Web;
using BattleNetApi.Client.Models.WoW;
using BattleNetApi.Client.Networking;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client
{
    public partial class WowApiClient
    {
        private static string GetAuctionDataUrl(string realm)
        {
            return $"/wow/auction/data/{HttpUtility.UrlEncode(realm)}";
        }

        public AuctionResponse GetAuctionData(Realm realm)
        {
            return GetAuctionData(realm.Slug);
        }

        public AuctionResponse GetAuctionData(string realm)
        {
            var result = GetApiResponse(ForgeApiRequest<AuctionResponse>(GetAuctionDataUrl(realm)));
            
            return _setupAuctionDataTasks(result);
        }

        public async Task<AuctionResponse> GetAuctionDataAsync(Realm realm)
        {
            return await GetAuctionDataAsync(realm.Slug);
        }

        public async Task<AuctionResponse> GetAuctionDataAsync(string realm)
        {
            var result = await GetApiResponseAsync(ForgeApiRequest<AuctionResponse>(GetAuctionDataUrl(realm)));

            return _setupAuctionDataTasks(result);
        }

        private AuctionResponse _setupAuctionDataTasks(AuctionResponse auctionResponse)
        {
            // Setup lazy loading tasks.
            foreach (var auctionFile in auctionResponse.AuctionFiles)
            {
                auctionFile.AuctionDataTask = _getAuctionDataTask(auctionFile);
            }

            return auctionResponse;
        }

        private Task<AuctionDataFile> _getAuctionDataTask(AuctionFile auctionFile)
        {
            return new Task<AuctionDataFile>(() =>
            {
                var apiResponse = ApiProvider.GetFromJson(new ApiRequest<AuctionDataFile>(new Uri(auctionFile.Url)));
                return apiResponse;
            });
        }
    }
}
