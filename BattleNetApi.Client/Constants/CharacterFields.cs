using System;

namespace BattleNetApi.Client.Constants
{
    [Flags]
    public enum CharacterFields
    {
        None = 0,

        Achievements = 1,
        Appearance = 2,
        Feed = 4,
        Guild = 8,
        HunterPets = 16,
        Items = 32,
        Mounts = 64,
        Pets = 128,
        PetSlots = 256,
        Professions = 512,
        Progression = 1024,
        Pvp = 2048,
        Quests = 4096,
        Reputation = 8192,
        Statistics = 16384,
        Stats = 32768,
        Talents = 65536,
        Titles = 131072,
        Audit = 262144,

        All = Achievements | Appearance | Feed | Guild | HunterPets | Items | Mounts
            | Pets | PetSlots | Professions | Progression | Pvp | Quests | Reputation
            | Statistics | Stats | Talents | Titles | Audit
    }
}