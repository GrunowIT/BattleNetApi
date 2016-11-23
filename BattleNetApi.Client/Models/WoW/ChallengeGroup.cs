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
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeGroup
    {
        [JsonProperty("ranking")]
        public int Ranking { get; set; }
        [JsonProperty("time")]
        public Time Time { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("medal")]
        public string Medal { get; set; }
        [JsonProperty("faction")]
        public string Faction { get; set; }
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }
        [JsonProperty("members")]
        public ChallengeGroupMember[] Members { get; set; }
    }
}