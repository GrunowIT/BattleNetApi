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
    public class AchievementRewardItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }
        [JsonProperty("stats")]
        public ItemStat[] Stats { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("bonusLists")]
        public int[] BonusLists { get; set; }
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }
        [JsonProperty("artifactAppearanceId")]
        public int ArtifactAppearanceId { get; set; }
        [JsonProperty("artifactTraits")]
        public ArtifactTrait[] ArtifactTraits { get; set; }
        [JsonProperty("relics")]
        public Relic[] Relics { get; set; }
        [JsonProperty("appearance")]
        public ItemAppearance Appearance { get; set; }
    }
}