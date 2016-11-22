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
    public class AuctionResponse : IApiEndpoint
    {
        [JsonProperty(propertyName: "files")]
        public AuctionFile[] AuctionFiles { get; set; }
    }

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

    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionDataFile : IApiEndpoint
    {
        [JsonProperty(propertyName: "realms")]
        public Realm[] Realms { get; set; }
        [JsonProperty(propertyName: "auctions")]
        public Auction[] Auctions { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Auction
    {
        [JsonProperty("auc")]
        public int AuctionId { get; set; }
        [JsonProperty("item")]
        public int ItemId { get; set; }
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("OwnerRealm")]
        public string OwnerRealm { get; set; }
        [JsonProperty("bid")]
        public long Bid { get; set; }
        [JsonProperty("buyout")]
        public long Buyout { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }
        [JsonProperty("rand")]
        public int Rand { get; set; }
        [JsonProperty("seed")]
        public long Seed { get; set; }
        [JsonProperty("context")]
        public int Context { get; set; }
        [JsonProperty("bonusLists")]
        public AuctionBonusList[] BonusLists { get; set; }
        [JsonProperty("modifiers")]
        public AuctionModifier[] Modifiers { get; set; }
        [JsonProperty("petSpeciesId")]
        public int PetSpeciesId { get; set; }
        [JsonProperty("petBreedId")]
        public int PetBreedId { get; set; }
        [JsonProperty("petLevel")]
        public int PetLevel { get; set; }
        [JsonProperty("petQualityId")]
        public int PetQualityId { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionBonusList
    {
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class AuctionModifier
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
