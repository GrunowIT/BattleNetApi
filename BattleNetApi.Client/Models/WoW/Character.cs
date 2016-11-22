﻿/*
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
    public class Character : IApiEndpoint
    {
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("_class")]
        public int Class { get; set; }
        [JsonProperty("race")]
        public int Race { get; set; }
        [JsonProperty("gender")]
        public int Gender { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("calcClass")]
        public string CalcClass { get; set; }
        [JsonProperty("faction")]
        public int Faction { get; set; }
        [JsonProperty("totalHonorableKills")]
        public int TotalHonorableKills { get; set; }

        #region Extra properties
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }
        [JsonProperty("appearance")]
        public CharacterAppearance Appearance { get; set; }
        [JsonProperty("feed")]
        public CharacterFeedEntry[] Feed { get; set; }
        [JsonProperty("guild")]
        public Guild Guild { get; set; }
        [JsonProperty("hunterPets")]
        public HunterPet[] HunterPets { get; set; }
        [JsonProperty("items")]
        public Items Items { get; set; }
        [JsonProperty("mounts")]
        public CharacterMounts Mounts { get; set; }
        [JsonProperty("pets")]
        public CharacterPets Pets { get; set; }
        [JsonProperty("petSlots")]
        public CharacterPetSlot[] PetSlots { get; set; }
        [JsonProperty("professions")]
        public Professions Professions { get; set; }
        [JsonProperty("progression")]
        public CharacterProgression Progression { get; set; }
        [JsonProperty("pvp")]
        public Pvp Pvp { get; set; }
        #endregion
    }
}
