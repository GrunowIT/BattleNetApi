using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ArtifactTrait
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}