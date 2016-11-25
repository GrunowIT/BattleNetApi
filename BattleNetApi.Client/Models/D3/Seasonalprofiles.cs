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
    public class Seasonalprofiles
    {
        [JsonProperty("season0")]
        public SeasonInfo Season0 { get; set; }
        [JsonProperty("season1")]
        public SeasonInfo Season1 { get; set; }
        [JsonProperty("season2")]
        public SeasonInfo Season2 { get; set; }
        [JsonProperty("season3")]
        public SeasonInfo Season3 { get; set; }
        [JsonProperty("season4")]
        public SeasonInfo Season4 { get; set; }
        [JsonProperty("season6")]
        public SeasonInfo Season6 { get; set; }
        [JsonProperty("season5")]
        public SeasonInfo Season5 { get; set; }
        [JsonProperty("season7")]
        public SeasonInfo Season7 { get; set; }
    }
}