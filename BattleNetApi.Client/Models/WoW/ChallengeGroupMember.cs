using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeGroupMember
    {
        [JsonProperty("character")]
        public ChallengeCharacter Character { get; set; }
        [JsonProperty("spec")]
        public Spec Spec { get; set; }
    }
}