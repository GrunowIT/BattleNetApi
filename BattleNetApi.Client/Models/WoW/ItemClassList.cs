using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemClassList : IApiEndpoint
    {
        [JsonProperty("classes")]
        public ItemClass[] Classes { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemClass
    {
        [JsonProperty("class")]
        public int Class { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("subclasses")]
        public ItemSubClass[] Subclasses { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSubClass
    {
        [JsonProperty("subclass")]
        public int Subclass { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
