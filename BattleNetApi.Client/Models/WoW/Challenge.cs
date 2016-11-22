using System;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeList : IApiEndpoint
    {
        [JsonProperty("challenge")]
        public Challenge[] Challenge { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Challenge
    {
        [JsonProperty("realm")]
        public Realm Realm { get; set; }
        [JsonProperty("map")]
        public Map Map { get; set; }
        [JsonProperty("groups")]
        public Group[] Groups { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Map
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("hasChallengeMode")]
        public bool HasChallengeMode { get; set; }
        [JsonProperty("bronzeCriteria")]
        public Bronzecriteria BronzeCriteria { get; set; }
        [JsonProperty("silverCriteria")]
        public Silvercriteria SilverCriteria { get; set; }
        [JsonProperty("goldCriteria")]
        public Goldcriteria GoldCriteria { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Bronzecriteria
    {
        [JsonProperty("time")]
        public int Time { get; set; }
        [JsonProperty("hours")]
        public int Hours { get; set; }
        [JsonProperty("minutes")]
        public int Minutes { get; set; }
        [JsonProperty("seconds")]
        public int Seconds { get; set; }
        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Silvercriteria
    {
        [JsonProperty("time")]
        public int Time { get; set; }
        [JsonProperty("hours")]
        public int Hours { get; set; }
        [JsonProperty("minutes")]
        public int Minutes { get; set; }
        [JsonProperty("seconds")]
        public int Seconds { get; set; }
        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Goldcriteria
    {
        [JsonProperty("time")]
        public int Time { get; set; }
        [JsonProperty("hours")]
        public int Hours { get; set; }
        [JsonProperty("minutes")]
        public int Minutes { get; set; }
        [JsonProperty("seconds")]
        public int Seconds { get; set; }
        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Group
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
        public Member[] Members { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Time
    {
        [JsonProperty("time")]
        public long TotalMilliseconds { get; set; }
        [JsonProperty("hours")]
        public int Hours { get; set; }
        [JsonProperty("minutes")]
        public int Minutes { get; set; }
        [JsonProperty("seconds")]
        public int Seconds { get; set; }
        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Member
    {
        [JsonProperty("character")]
        public ChallengeCharacter Character { get; set; }
        [JsonProperty("spec")]
        public Spec Spec { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ChallengeCharacter
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("_class")]
        public int Class { get; set; }
        [JsonProperty("race")]
        public int Race { get; set; }
        [JsonProperty("gender")]
        public int Gender { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("spec")]
        public Spec Spec { get; set; }
        [JsonProperty("guild")]
        public string Guild { get; set; }
        [JsonProperty("guildRealm")]
        public string GuildRealm { get; set; }
        [JsonProperty("lastModified")]
        public int LastModified { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Spec
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
    }
}
