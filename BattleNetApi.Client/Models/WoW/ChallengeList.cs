using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeList : IApiEndpoint
    {
        [JsonProperty("challenge")]
        public Challenge[] Challenge { get; set; }
    }
}