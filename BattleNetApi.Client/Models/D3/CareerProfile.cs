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
    public class CareerProfile
    {
        [JsonProperty("battleTag")]
        public string BattleTag { get; set; }
        [JsonProperty("paragonLevel")]
        public int ParagonLevel { get; set; }
        [JsonProperty("paragonLevelHardcore")]
        public int ParagonLevelHardcore { get; set; }
        [JsonProperty("paragonLevelSeason")]
        public int ParagonLevelSeason { get; set; }
        [JsonProperty("paragonLevelSeasonHardcore")]
        public int ParagonLevelSeasonHardcore { get; set; }
        [JsonProperty("guildName")]
        public string GuildName { get; set; }
        [JsonProperty("heroes")]
        public Hero[] Heroes { get; set; }
        [JsonProperty("lastHeroPlayed")]
        public int LastHeroPlayed { get; set; }
        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }
        [JsonProperty("kills")]
        public Kills Kills { get; set; }
        [JsonProperty("highestHardcoreLevel")]
        public int HighestHardcoreLevel { get; set; }
        [JsonProperty("timePlayed")]
        public TimePlayed TimePlayed { get; set; }
        [JsonProperty("progression")]
        public ActCompletionInfo Progression { get; set; }
        [JsonProperty("fallenHeroes")]
        public Hero[] FallenHeroes { get; set; }
        [JsonProperty("blacksmith")]
        public ArtisanInfo Blacksmith { get; set; }
        [JsonProperty("jeweler")]
        public ArtisanInfo Jeweler { get; set; }
        [JsonProperty("mystic")]
        public ArtisanInfo Mystic { get; set; }
        [JsonProperty("blacksmithHardcore")]
        public ArtisanInfo BlacksmithHardcore { get; set; }
        [JsonProperty("jewelerHardcore")]
        public ArtisanInfo JewelerHardcore { get; set; }
        [JsonProperty("mysticHardcore")]
        public ArtisanInfo MysticHardcore { get; set; }
        [JsonProperty("blacksmithSeasonHardcore")]
        public ArtisanInfo BlacksmithSeasonHardcore { get; set; }
        [JsonProperty("jewelerSeasonHardcore")]
        public ArtisanInfo JewelerSeasonHardcore { get; set; }
        [JsonProperty("mysticSeasonHardcore")]
        public ArtisanInfo MysticSeasonHardcore { get; set; }
        [JsonProperty("seasonalProfiles")]
        public Seasonalprofiles SeasonalProfiles { get; set; }
    }
}
