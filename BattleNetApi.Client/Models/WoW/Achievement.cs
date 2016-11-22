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
    public class Achievement : IApiEndpoint
    {
        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }
        [JsonProperty(propertyName: "title")]
        public string Title { get; set; }
        [JsonProperty(propertyName: "points")]
        public int Points { get; set; }
        [JsonProperty(propertyName: "description")]
        public string Description { get; set; }
        [JsonProperty(propertyName: "reward")]
        public string Reward { get; set; }
        [JsonProperty(propertyName: "icon")]
        public string Icon { get; set; }
        [JsonProperty(propertyName: "accountWide")]
        public bool AccountWide { get; set; }
        [JsonProperty("factionId")]
        public int FactionId { get; set; }
        [JsonProperty(propertyName: "rewardItems")]
        public AchievementRewardItem[] RewardItems { get; set; }
        [JsonProperty(propertyName: "criteria")]
        public AchievementCriterion[] Criteria { get; set; }
    }
}
