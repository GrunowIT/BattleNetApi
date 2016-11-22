using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSet : IApiEndpoint
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("setBonuses")]
        public ItemSetBonus[] SetBonuses { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}