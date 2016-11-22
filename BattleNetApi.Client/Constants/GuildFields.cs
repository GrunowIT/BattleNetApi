using System;

namespace BattleNetApi.Client.Constants
{
    [Flags]
    public enum GuildFields
    {
        None = 0,

        Members = 1,
        Achievements = 2,
        News = 4,
        Challenge = 8,

        All = Members | Achievements | News | Challenge
    }
}