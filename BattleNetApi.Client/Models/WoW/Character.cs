using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Character : IApiEndpoint
    {
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }
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
        [JsonProperty("calcClass")]
        public string CalcClass { get; set; }
        [JsonProperty("faction")]
        public int Faction { get; set; }
        [JsonProperty("totalHonorableKills")]
        public int TotalHonorableKills { get; set; }

        #region Extra properties
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }
        [JsonProperty("appearance")]
        public Appearance Appearance { get; set; }
        [JsonProperty("feed")]
        public FeedEntry[] Feed { get; set; }
        [JsonProperty("guild")]
        public Guild Guild { get; set; }
        [JsonProperty("hunterPets")]
        public HunterPet[] HunterPets { get; set; }
        [JsonProperty("items")]
        public Items Items { get; set; }
        [JsonProperty("mounts")]
        public Mounts Mounts { get; set; }
        [JsonProperty("pets")]
        public Pets Pets { get; set; }
        [JsonProperty("petSlots")]
        public Petslot[] PetSlots { get; set; }
        [JsonProperty("professions")]
        public Professions Professions { get; set; }
        [JsonProperty("progression")]
        public Progression Progression { get; set; }
        [JsonProperty("pvp")]
        public Pvp Pvp { get; set; }
        #endregion
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Achievements
    {
        [JsonProperty("achievementsCompleted")]
        public int[] AchievementsCompleted { get; set; }
        [JsonProperty("achievementsCompletedTimestamp")]
        public long[] AchievementsCompletedTimestamp { get; set; }
        [JsonProperty("criteria")]
        public int[] Criteria { get; set; }
        [JsonProperty("criteriaQuantity")]
        public long[] CriteriaQuantity { get; set; }
        [JsonProperty("criteriaTimestamp")]
        public long[] CriteriaTimestamp { get; set; }
        [JsonProperty("criteriaCreated")]
        public long[] CriteriaCreated { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Appearance
    {
        [JsonProperty("faceVariation")]
        public int FaceVariation { get; set; }
        [JsonProperty("skinColor")]
        public int SkinColor { get; set; }
        [JsonProperty("hairVariation")]
        public int HairVariation { get; set; }
        [JsonProperty("hairColor")]
        public int HairColor { get; set; }
        [JsonProperty("featureVariation")]
        public int FeatureVariation { get; set; }
        [JsonProperty("showHelm")]
        public bool ShowHelm { get; set; }
        [JsonProperty("showCloak")]
        public bool ShowCloak { get; set; }
        [JsonProperty("customDisplayOptions")]
        public int[] CustomDisplayOptions { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class FeedEntry
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("achievement")]
        public Achievement Achievement { get; set; }
        [JsonProperty("featOfStrength")]
        public bool FeatOfStrength { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("bonusLists")]
        public int[] BonusLists { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class AchievementRewardItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }
        [JsonProperty("stats")]
        public object[] Stats { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("bonusLists")]
        public object[] BonusLists { get; set; }
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }
        [JsonProperty("artifactAppearanceId")]
        public int ArtifactAppearanceId { get; set; }
        [JsonProperty("artifactTraits")]
        public object[] ArtifactTraits { get; set; }
        [JsonProperty("relics")]
        public object[] Relics { get; set; }
        [JsonProperty("appearance")]
        public ItemAppearance Appearance { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class TooltipParams
    {
        [JsonProperty(propertyName: "gem0")]
        public int Gem0 { get; set; }
        [JsonProperty(propertyName: "gem1")]
        public int Gem1 { get; set; }
        [JsonProperty(propertyName: "gem2")]
        public int Gem2 { get; set; }
        [JsonProperty(propertyName: "enchant")]
        public int Enchant { get; set; }
        [JsonProperty(propertyName: "reforge")]
        public int Reforge { get; set; }
        [JsonProperty(propertyName: "set")]
        public int[] Sets { get; set; }
        [JsonProperty(propertyName: "seed")]
        public long Seed { get; set; }
        [JsonProperty(propertyName: "extraSocket")]
        public bool ExtraSocket { get; set; }
        [JsonProperty(propertyName: "suffix")]
        public int Suffix { get; set; }
        [JsonProperty("transmogItem")]
        public int TransmogItem { get; set; }
        [JsonProperty("timewalkerLevel")]
        public int TimewalkerLevel { get; set; }
        [JsonProperty(propertyName: "upgrade")]
        public ItemLevelUpgrade ItemLevelUpgrade { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemLevelUpgrade
    {
        [JsonProperty("current")]
        public int Current { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("itemLevelIncrement")]
        public int ItemLevelIncrement { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemAppearance
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("itemAppearanceModId")]
        public int ItemAppearanceModId { get; set; }
        [JsonProperty("enchantDisplayInfoId")]
        public int EnchantDisplayInfoId { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class AchievementCriterion
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("orderIndex")]
        public int OrderIndex { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Guild
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("members")]
        public int Members { get; set; }
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }
        [JsonProperty("emblem")]
        public Emblem Emblem { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Emblem
    {
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("iconColor")]
        public string IconColor { get; set; }
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }
        [JsonProperty("border")]
        public int Border { get; set; }
        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }
        [JsonProperty("borderColorId")]
        public int BorderColorId { get; set; }
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
        [JsonProperty("backgroundColorId")]
        public int BackgroundColorId { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class HunterPet
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("creature")]
        public int Creature { get; set; }
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("spec")]
        public Spec Spec { get; set; }
        [JsonProperty("calcSpec")]
        public string CalcSpec { get; set; }
        [JsonProperty("familyId")]
        public int FamilyId { get; set; }
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Items
    {
        [JsonProperty("averageItemLevel")]
        public int AverageItemLevel { get; set; }
        [JsonProperty("averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; set; }
        [JsonProperty("head")]
        public SlotItemInfo Head { get; set; }
        [JsonProperty("neck")]
        public SlotItemInfo Neck { get; set; }
        [JsonProperty("shoulder")]
        public SlotItemInfo Shoulder { get; set; }
        [JsonProperty("back")]
        public SlotItemInfo Back { get; set; }
        [JsonProperty("chest")]
        public SlotItemInfo Chest { get; set; }
        [JsonProperty("wrist")]
        public SlotItemInfo Wrist { get; set; }
        [JsonProperty("hands")]
        public SlotItemInfo Hands { get; set; }
        [JsonProperty("waist")]
        public SlotItemInfo Waist { get; set; }
        [JsonProperty("legs")]
        public SlotItemInfo Legs { get; set; }
        [JsonProperty("feet")]
        public SlotItemInfo Feet { get; set; }
        [JsonProperty("finger1")]
        public SlotItemInfo Finger1 { get; set; }
        [JsonProperty("finger2")]
        public SlotItemInfo Finger2 { get; set; }
        [JsonProperty("trinket1")]
        public SlotItemInfo Trinket1 { get; set; }
        [JsonProperty("trinket2")]
        public SlotItemInfo Trinket2 { get; set; }
        [JsonProperty("mainHand")]
        public SlotItemInfo MainHand { get; set; }
        [JsonProperty("offHand")]
        public SlotItemInfo OffHand { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class SlotItemInfo
    {
        [JsonProperty("appearance")]
        public ItemAppearance Appearance { get; set; }
        [JsonProperty("artifactTraits")]
        public ArtifactTrait[] ArtifactTraits { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("artifactAppearanceId")]
        public int ArtifactAppearanceId { get; set; }
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("bonusLists")]
        public int[] BonusLists { get; set; }
        [JsonProperty("relics")]
        public Relic[] Relics { get; set; }
        [JsonProperty("stats")]
        public ItemStat[] Stats { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }
        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemStat
    {
        [JsonProperty("stat")]
        public int Stat { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class WeaponInfo
    {
        [JsonProperty("damage")]
        public Damage Damage { get; set; }
        [JsonProperty("weaponSpeed")]
        public float WeaponSpeed { get; set; }
        [JsonProperty("dps")]
        public float Dps { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Damage
    {
        [JsonProperty("min")]
        public int Min { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
        [JsonProperty("exactMin")]
        public float ExactMin { get; set; }
        [JsonProperty("exactMax")]
        public float ExactMax { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ArtifactTrait
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Relic
    {
        [JsonProperty("socket")]
        public int Socket { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("context")]
        public int Context { get; set; }
        [JsonProperty("bonusLists")]
        public int[] BonusLists { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Mounts
    {
        [JsonProperty("numCollected")]
        public int NumCollected { get; set; }
        [JsonProperty("numNotCollected")]
        public int NumNotCollected { get; set; }
        [JsonProperty("collected")]
        public CollectedMountInfo[] CollectedMounts { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class CollectedMountInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("qualityId")]
        public int QualityId { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("isGround")]
        public bool IsGround { get; set; }
        [JsonProperty("isFlying")]
        public bool IsFlying { get; set; }
        [JsonProperty("isAquatic")]
        public bool IsAquatic { get; set; }
        [JsonProperty("isJumping")]
        public bool IsJumping { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Pets
    {
        [JsonProperty("numCollected")]
        public int NumCollected { get; set; }
        [JsonProperty("numNotCollected")]
        public int NumNotCollected { get; set; }
        [JsonProperty("collected")]
        public CollectedPetInfo[] CollectedPets { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class CollectedPetInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("qualityId")]
        public int QualityId { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("stats")]
        public PetStats PetStats { get; set; }
        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }
        [JsonProperty("isFavorite")]
        public bool IsFavorite { get; set; }
        [JsonProperty("isFirstAbilitySlotSelected")]
        public bool IsFirstAbilitySlotSelected { get; set; }
        [JsonProperty("isSecondAbilitySlotSelected")]
        public bool IsSecondAbilitySlotSelected { get; set; }
        [JsonProperty("isThirdAbilitySlotSelected")]
        public bool IsThirdAbilitySlotSelected { get; set; }
        [JsonProperty("creatureName")]
        public string CreatureName { get; set; }
        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }
    }

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

    [JsonObject(MemberSerialization.OptIn)]
    public class Petslot
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }
        [JsonProperty("isEmpty")]
        public bool IsEmpty { get; set; }
        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }
        [JsonProperty("abilities")]
        public int[] Abilities { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Professions
    {
        [JsonProperty("primary")]
        public ProfessionInfo[] Primary { get; set; }
        [JsonProperty("secondary")]
        public ProfessionInfo[] Secondary { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ProfessionInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
        [JsonProperty("recipes")]
        public int?[] Recipes { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Progression
    {
        [JsonProperty("raids")]
        public Raid[] Raids { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Raid
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("lfr")]
        public int Lfr { get; set; }
        [JsonProperty("normal")]
        public int Normal { get; set; }
        [JsonProperty("heroic")]
        public int Heroic { get; set; }
        [JsonProperty("mythic")]
        public int Mythic { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("bosses")]
        public RaidBoss[] Bosses { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class RaidBoss
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("normalKills")]
        public int NormalKills { get; set; }
        [JsonProperty("normalTimestamp")]
        public long NormalTimestamp { get; set; }
        [JsonProperty("heroicKills")]
        public int HeroicKills { get; set; }
        [JsonProperty("heroicTimestamp")]
        public int HeroicTimestamp { get; set; }
        [JsonProperty("lfrKills")]
        public int LfrKills { get; set; }
        [JsonProperty("lfrTimestamp")]
        public long LfrTimestamp { get; set; }
        [JsonProperty("mythicKills")]
        public int MythicKills { get; set; }
        [JsonProperty("mythicTimestamp")]
        public int MythicTimestamp { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Pvp
    {
        [JsonProperty("brackets")]
        public Brackets Brackets { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Brackets
    {
        [JsonProperty("ARENA_BRACKET_2v2")]
        public ArenaInfo ArenaBracket_2V2 { get; set; }
        [JsonProperty("ARENA_BRACKET_3v3")]
        public ArenaInfo ArenaBracket_3V3 { get; set; }
        [JsonProperty("ARENA_BRACKET_RBG")]
        public ArenaInfo ArenaBracketRbg { get; set; }
        [JsonProperty("ARENA_BRACKET_2v2_SKIRMISH")]
        public ArenaInfo ArenaBracket_2V2Skirmish { get; set; }
        [JsonProperty("UNKNOWN")]
        public ArenaInfo Unknown { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ArenaInfo
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("weeklyPlayed")]
        public int WeeklyPlayed { get; set; }
        [JsonProperty("weeklyWon")]
        public int WeeklyWon { get; set; }
        [JsonProperty("weeklyLost")]
        public int WeeklyLost { get; set; }
        [JsonProperty("seasonPlayed")]
        public int SeasonPlayed { get; set; }
        [JsonProperty("seasonWon")]
        public int SeasonWon { get; set; }
        [JsonProperty("seasonLost")]
        public int SeasonLost { get; set; }
    }
}
