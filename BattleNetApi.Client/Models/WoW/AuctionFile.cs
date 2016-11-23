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
using BattleNetApi.Client.Networking;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionFile
    {
        [JsonProperty(propertyName: "url")]
        public string Url { get; set; }
        [JsonProperty(propertyName: "lastModified")]
        public long LastModified { get; set; }

        public Task<AuctionDataFile> AuctionDataTask { get; set; }

        private AuctionDataFile _auctionDataFile;
        /// <summary>
        /// Gets the auction data from the url provided.
        /// This is done in a separate task via lazy loading.
        /// </summary>
        [JsonIgnore]
        public AuctionDataFile AuctionData => AuctionDataTask == null ? null : _auctionDataFile ?? (_auctionDataFile = AuctionDataDownloadManager.Enqueue(this).Result);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="auctionDataTask"></param>
        public AuctionFile(Task<AuctionDataFile> auctionDataTask = null)
        {
            AuctionDataTask = auctionDataTask;
        }
    }
}