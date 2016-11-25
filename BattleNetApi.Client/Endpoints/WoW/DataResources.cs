/*
    BattleNetApi - A .NET battle.net API library.
    Copyright (C) 2016  Sebastian Grunow <sebastian@grunow-it.de>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    */

using System.Threading.Tasks;
using BattleNetApi.Client.Models.WoW;

// ReSharper disable once CheckNamespace
namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient
    {
        private static readonly string GetDataResourceUrlBase = "/wow/data/";
        private static readonly string GetDataResourceUrlBattlegroups = GetDataResourceUrlBase + "battlegroups/";
        private static readonly string GetDataResourceUrlCharacterRaces = GetDataResourceUrlBase + "character/races";
        private static readonly string GetDataResourceUrlCharacterClasses = GetDataResourceUrlBase + "character/classes";
        private static readonly string GetDataResourceUrlCharacterAchievements = GetDataResourceUrlBase + "character/achievements";
        private static readonly string GetDataResourceUrlGuildRewards = GetDataResourceUrlBase + "guild/rewards";
        private static readonly string GetDataResourceUrlGuildPerks = GetDataResourceUrlBase + "guild/perks";
        private static readonly string GetDataResourceUrlGuildAchievements = GetDataResourceUrlBase + "guild/achievements";
        private static readonly string GetDataResourceUrlItemClasses = GetDataResourceUrlBase + "item/classes";
        private static readonly string GetDataResourceUrlTalents = GetDataResourceUrlBase + "talents";
        private static readonly string GetDataResourceUrlPetTypes = GetDataResourceUrlBase + "pet/types";

        #region Battlegroups
        public BattlegroupList GetDataBattlegroups()
        {
            return GetApiResponse(ForgeApiRequest<BattlegroupList>(GetDataResourceUrlBattlegroups));
        }
        public async Task<BattlegroupList> GetDataBattlegroupsAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<BattlegroupList>(GetDataResourceUrlBattlegroups));
        }
        #endregion

        #region Character Data
        public CharacterRaceList GetDataCharacterRaces()
        {
            return GetApiResponse(ForgeApiRequest<CharacterRaceList>(GetDataResourceUrlCharacterRaces));
        }
        public async Task<CharacterRaceList> GetDataCharacterRacesAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<CharacterRaceList>(GetDataResourceUrlCharacterRaces));
        }

        public CharacterClassList GetDataCharacterClasses()
        {
            return GetApiResponse(ForgeApiRequest<CharacterClassList>(GetDataResourceUrlCharacterClasses));
        }
        public async Task<CharacterClassList> GetDataCharacterClassesAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<CharacterClassList>(GetDataResourceUrlCharacterClasses));
        }

        public AchievementList GetDataCharacterAchievements()
        {
            return GetApiResponse(ForgeApiRequest<AchievementList>(GetDataResourceUrlCharacterAchievements));
        }
        public async Task<AchievementList> GetDataCharacterAchievementsAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<AchievementList>(GetDataResourceUrlCharacterAchievements));
        }
        #endregion

        #region Guild Data
        public GuildRewardList GetDataGuildRewards()
        {
            return GetApiResponse(ForgeApiRequest<GuildRewardList>(GetDataResourceUrlGuildRewards));
        }
        public async Task<GuildRewardList> GetDataGuildRewardsAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<GuildRewardList>(GetDataResourceUrlGuildRewards));
        }

        public GuildPerkList GetDataGuildPerks()
        {
            return GetApiResponse(ForgeApiRequest<GuildPerkList>(GetDataResourceUrlGuildPerks));
        }
        public async Task<GuildPerkList> GetDataGuildPerksAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<GuildPerkList>(GetDataResourceUrlGuildPerks));
        }

        public AchievementList GetDataGuildAchievements()
        {
            return GetApiResponse(ForgeApiRequest<AchievementList>(GetDataResourceUrlGuildAchievements));
        }
        public async Task<AchievementList> GetDataGuildAchievementsAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<AchievementList>(GetDataResourceUrlGuildAchievements));
        }
        #endregion

        #region Item Data
        public ItemClassList GetDataItemClasses()
        {
            return GetApiResponse(ForgeApiRequest<ItemClassList>(GetDataResourceUrlItemClasses));
        }
        public async Task<ItemClassList> GetDataItemClassesAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<ItemClassList>(GetDataResourceUrlItemClasses));
        }
        #endregion

        #region Talent Data
        public ClassTalentsList GetDataTalents()
        {
            return GetApiResponse(ForgeApiRequest<ClassTalentsList>(GetDataResourceUrlTalents));
        }
        public async Task<ClassTalentsList> GetDataTalentsAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<ClassTalentsList>(GetDataResourceUrlTalents));
        }
        #endregion

        #region Pet Data
        public PetTypeList GetDataPetTypes()
        {
            return GetApiResponse(ForgeApiRequest<PetTypeList>(GetDataResourceUrlPetTypes));
        }
        public async Task<PetTypeList> GetDataPetTypesAsync()
        {
            return await GetApiResponseAsync(ForgeApiRequest<PetTypeList>(GetDataResourceUrlPetTypes));
        }
        #endregion
    }
}
