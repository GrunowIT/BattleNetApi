namespace BattleNetApi.Client.Constants
{
    public enum Region
    {
        [ApiRegion("https://us.api.battle.net")]
        US,

        [ApiRegion("https://eu.api.battle.net")]
        EU,

        [ApiRegion("https://kr.api.battle.net")]
        KR,

        [ApiRegion("https://tw.api.battle.net")]
        TW,

        [ApiRegion("https://api.battlenet.com.cn")]
        CN,

        [ApiRegion("https://sea.api.battle.net")]
        SEA
    }
}