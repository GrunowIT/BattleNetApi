using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WeaponInfo
    {
        [JsonProperty("damage")]
        public WeaponDamage Damage { get; set; }
        [JsonProperty("weaponSpeed")]
        public float WeaponSpeed { get; set; }
        [JsonProperty("dps")]
        public float Dps { get; set; }
    }
}