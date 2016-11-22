using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterAppearance
    {
        [JsonProperty("faceVariation")]
        public int FaceVariation { get; set; }
        [JsonProperty("skinColor")]
        public int SkinColor { get; set; }
        [JsonProperty("hairVariation")]
        public int HairVariation { get; set; }
        [JsonProperty("hairColor")]
        public int HairColor { get; set; }
        [JsonProperty("featureVariation")]
        public int FeatureVariation { get; set; }
        [JsonProperty("showHelm")]
        public bool ShowHelm { get; set; }
        [JsonProperty("showCloak")]
        public bool ShowCloak { get; set; }
        [JsonProperty("customDisplayOptions")]
        public int[] CustomDisplayOptions { get; set; }
    }
}