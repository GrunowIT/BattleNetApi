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