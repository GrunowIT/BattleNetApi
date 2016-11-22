using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemAppearance
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("itemAppearanceModId")]
        public int ItemAppearanceModId { get; set; }
        [JsonProperty("enchantDisplayInfoId")]
        public int EnchantDisplayInfoId { get; set; }
    }
}