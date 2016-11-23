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
    public class TooltipParams
    {
        [JsonProperty("gem0")]
        public int Gem0 { get; set; }
        [JsonProperty("gem1")]
        public int Gem1 { get; set; }
        [JsonProperty("gem2")]
        public int Gem2 { get; set; }
        [JsonProperty("enchant")]
        public int Enchant { get; set; }
        [JsonProperty("reforge")]
        public int Reforge { get; set; }
        [JsonProperty("set")]
        public int[] Sets { get; set; }
        [JsonProperty("seed")]
        public long Seed { get; set; }
        [JsonProperty("extraSocket")]
        public bool ExtraSocket { get; set; }
        [JsonProperty("suffix")]
        public int Suffix { get; set; }
        [JsonProperty("transmogItem")]
        public int TransmogItem { get; set; }
        [JsonProperty("timewalkerLevel")]
        public int TimewalkerLevel { get; set; }
        [JsonProperty("upgrade")]
        public ItemLevelUpgrade ItemLevelUpgrade { get; set; }
    }
}