using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PetStats
    {
        [JsonProperty("speciesId")]
        public int SpeciesId { get; set; }
        [JsonProperty("breedId")]
        public int BreedId { get; set; }
        [JsonProperty("petQualityId")]
        public int PetQualityId { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("health")]
        public int Health { get; set; }
        [JsonProperty("power")]
        public int Power { get; set; }
        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}