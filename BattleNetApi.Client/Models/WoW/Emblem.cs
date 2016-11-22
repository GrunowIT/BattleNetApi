using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Emblem
    {
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("iconColor")]
        public string IconColor { get; set; }
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }
        [JsonProperty("border")]
        public int Border { get; set; }
        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }
        [JsonProperty("borderColorId")]
        public int BorderColorId { get; set; }
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
        [JsonProperty("backgroundColorId")]
        public int BackgroundColorId { get; set; }
    }
}