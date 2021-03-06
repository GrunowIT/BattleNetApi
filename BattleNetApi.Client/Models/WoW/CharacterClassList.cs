﻿using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CharacterClassList : IApiEndpoint
    {
        [JsonProperty("classes")]
        public CharacterClass[] Classes { get; set; }
    }
}