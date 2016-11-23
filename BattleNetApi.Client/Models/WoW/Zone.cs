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

using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Zone : IApiEndpoint
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("expansionId")]
        public int ExpansionId { get; set; }
        [JsonProperty("numPlayers")]
        public string NumPlayers { get; set; }
        [JsonProperty("isDungeon")]
        public bool IsDungeon { get; set; }
        [JsonProperty("isRaid")]
        public bool IsRaid { get; set; }
        [JsonProperty("advisedMinLevel")]
        public int AdvisedMinLevel { get; set; }
        [JsonProperty("advisedMaxLevel")]
        public int AdvisedMaxLevel { get; set; }
        [JsonProperty("advisedHeroicMinLevel")]
        public int AdvisedHeroicMinLevel { get; set; }
        [JsonProperty("advisedHeroicMaxLevel")]
        public int AdvisedHeroicMaxLevel { get; set; }
        [JsonProperty("availableModes")]
        public string[] AvailableModes { get; set; }
        [JsonProperty("lfgNormalMinGearLevel")]
        public int LfgNormalMinGearLevel { get; set; }
        [JsonProperty("lfgHeroicMinGearLevel")]
        public int LfgHeroicMinGearLevel { get; set; }
        [JsonProperty("floors")]
        public int Floors { get; set; }
        [JsonProperty("bosses")]
        public Boss[] Bosses { get; set; }
        [JsonProperty("patch")]
        public string Patch { get; set; }
    }
}