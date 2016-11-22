using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Items
    {
        [JsonProperty("averageItemLevel")]
        public int AverageItemLevel { get; set; }
        [JsonProperty("averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; set; }
        [JsonProperty("head")]
        public SlotItemInfo Head { get; set; }
        [JsonProperty("neck")]
        public SlotItemInfo Neck { get; set; }
        [JsonProperty("shoulder")]
        public SlotItemInfo Shoulder { get; set; }
        [JsonProperty("back")]
        public SlotItemInfo Back { get; set; }
        [JsonProperty("chest")]
        public SlotItemInfo Chest { get; set; }
        [JsonProperty("wrist")]
        public SlotItemInfo Wrist { get; set; }
        [JsonProperty("hands")]
        public SlotItemInfo Hands { get; set; }
        [JsonProperty("waist")]
        public SlotItemInfo Waist { get; set; }
        [JsonProperty("legs")]
        public SlotItemInfo Legs { get; set; }
        [JsonProperty("feet")]
        public SlotItemInfo Feet { get; set; }
        [JsonProperty("finger1")]
        public SlotItemInfo Finger1 { get; set; }
        [JsonProperty("finger2")]
        public SlotItemInfo Finger2 { get; set; }
        [JsonProperty("trinket1")]
        public SlotItemInfo Trinket1 { get; set; }
        [JsonProperty("trinket2")]
        public SlotItemInfo Trinket2 { get; set; }
        [JsonProperty("mainHand")]
        public SlotItemInfo MainHand { get; set; }
        [JsonProperty("offHand")]
        public SlotItemInfo OffHand { get; set; }
    }
}