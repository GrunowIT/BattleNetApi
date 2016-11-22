using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSpell
    {
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
        [JsonProperty("spell")]
        public Spell Spell { get; set; }
        [JsonProperty("nCharges")]
        public int NCharges { get; set; }
        [JsonProperty("consumable")]
        public bool Consumable { get; set; }
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
        [JsonProperty("trigger")]
        public string Trigger { get; set; }
    }
}