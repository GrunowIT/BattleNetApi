using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WeaponDamage
    {
        [JsonProperty("min")]
        public int Min { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
        [JsonProperty("exactMin")]
        public float ExactMin { get; set; }
        [JsonProperty("exactMax")]
        public float ExactMax { get; set; }
    }
}