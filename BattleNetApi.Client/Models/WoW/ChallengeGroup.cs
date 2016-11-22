using System;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeGroup
    {
        [JsonProperty("ranking")]
        public int Ranking { get; set; }
        [JsonProperty("time")]
        public Time Time { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("medal")]
        public string Medal { get; set; }
        [JsonProperty("faction")]
        public string Faction { get; set; }
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }
        [JsonProperty("members")]
        public ChallengeGroupMember[] Members { get; set; }
    }
}