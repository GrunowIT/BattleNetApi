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

namespace BattleNetApi.Client.Models.D3
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CareerProfileHero
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("gender")]
        public int Gender { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("kills")]
        public Kills Kills { get; set; }
        [JsonProperty("paragonLevel")]
        public int ParagonLevel { get; set; }
        [JsonProperty("hardcore")]
        public bool Hardcore { get; set; }
        [JsonProperty("seasonal")]
        public bool Seasonal { get; set; }
        [JsonProperty("progression")]
        public ActCompletionInfo Progression { get; set; }
        [JsonProperty("dead")]
        public bool Dead { get; set; }
        [JsonProperty("lastupdated")]
        public int LastUpdated { get; set; }
    }
}
