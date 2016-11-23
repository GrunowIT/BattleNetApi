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
    public class RaidProgression
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("lfr")]
        public int Lfr { get; set; }
        [JsonProperty("normal")]
        public int Normal { get; set; }
        [JsonProperty("heroic")]
        public int Heroic { get; set; }
        [JsonProperty("mythic")]
        public int Mythic { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("bosses")]
        public RaidBossProgression[] Bosses { get; set; }
    }
}