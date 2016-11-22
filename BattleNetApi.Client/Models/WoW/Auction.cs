using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Auction
    {
        [JsonProperty("auc")]
        public int AuctionId { get; set; }
        [JsonProperty("item")]
        public int ItemId { get; set; }
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("OwnerRealm")]
        public string OwnerRealm { get; set; }
        [JsonProperty("bid")]
        public long Bid { get; set; }
        [JsonProperty("buyout")]
        public long Buyout { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }
        [JsonProperty("rand")]
        public int Rand { get; set; }
        [JsonProperty("seed")]
        public long Seed { get; set; }
        [JsonProperty("context")]
        public int Context { get; set; }
        [JsonProperty("bonusLists")]
        public AuctionBonusList[] BonusLists { get; set; }
        [JsonProperty("modifiers")]
        public AuctionModifier[] Modifiers { get; set; }
        [JsonProperty("petSpeciesId")]
        public int PetSpeciesId { get; set; }
        [JsonProperty("petBreedId")]
        public int PetBreedId { get; set; }
        [JsonProperty("petLevel")]
        public int PetLevel { get; set; }
        [JsonProperty("petQualityId")]
        public int PetQualityId { get; set; }
    }
}