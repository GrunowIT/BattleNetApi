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
    public class StatsInfo
    {
        [JsonProperty("life")]
        public int Life { get; set; }
        [JsonProperty("damage")]
        public float Damage { get; set; }
        [JsonProperty("toughness")]
        public float Toughness { get; set; }
        [JsonProperty("healing")]
        public float Healing { get; set; }
        [JsonProperty("attackSpeed")]
        public float AttackSpeed { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("strength")]
        public int Strength { get; set; }
        [JsonProperty("dexterity")]
        public int Dexterity { get; set; }
        [JsonProperty("vitality")]
        public int Vitality { get; set; }
        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }
        [JsonProperty("physicalResist")]
        public int PhysicalResist { get; set; }
        [JsonProperty("fireResist")]
        public int FireResist { get; set; }
        [JsonProperty("coldResist")]
        public int ColdResist { get; set; }
        [JsonProperty("lightningResist")]
        public int LightningResist { get; set; }
        [JsonProperty("poisonResist")]
        public int PoisonResist { get; set; }
        [JsonProperty("arcaneResist")]
        public int ArcaneResist { get; set; }
        [JsonProperty("critDamage")]
        public float CritDamage { get; set; }
        [JsonProperty("blockChance")]
        public float BlockChance { get; set; }
        [JsonProperty("blockAmountMin")]
        public int BlockAmountMin { get; set; }
        [JsonProperty("blockAmountMax")]
        public int BlockAmountMax { get; set; }
        [JsonProperty("damageIncrease")]
        public float DamageIncrease { get; set; }
        [JsonProperty("critChance")]
        public float CritChance { get; set; }
        [JsonProperty("damageReduction")]
        public float DamageReduction { get; set; }
        [JsonProperty("thorns")]
        public float Thorns { get; set; }
        [JsonProperty("lifeSteal")]
        public float LifeSteal { get; set; }
        [JsonProperty("lifePerKill")]
        public float LifePerKill { get; set; }
        [JsonProperty("goldFind")]
        public float GoldFind { get; set; }
        [JsonProperty("magicFind")]
        public float MagicFind { get; set; }
        [JsonProperty("lifeOnHit")]
        public float LifeOnHit { get; set; }
        [JsonProperty("experienceBonus")]
        public float ExperienceBonus { get; set; }
        [JsonProperty("primaryResource")]
        public int PrimaryResource { get; set; }
        [JsonProperty("secondaryResource")]
        public int SecondaryResource { get; set; }
    }
}