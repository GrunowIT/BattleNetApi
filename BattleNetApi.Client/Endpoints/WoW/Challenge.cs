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
using System.Web;
using BattleNetApi.Client.Models.WoW;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        private static string GetChallengeRealmLeaderboardUrl(string realm)
        {
            return $"/wow/challenge/{HttpUtility.UrlEncode(realm)}";
        }

        public ChallengeList GetChallengeRealmLeaderboard(Realm realm)
        {
            return GetChallengeRealmLeaderboard(realm.Slug);
        }

        public ChallengeList GetChallengeRealmLeaderboard(string realm)
        {
            return GetApiResponse(ForgeApiRequest<ChallengeList>(GetChallengeRealmLeaderboardUrl(realm)));
        }

        public async Task<ChallengeList> GetChallengeRealmLeaderboardAsync(Realm realm)
        {
            return await GetChallengeRealmLeaderboardAsync(realm.Slug);
        }

        public async Task<ChallengeList> GetChallengeRealmLeaderboardAsync(string realm)
        {
            return await GetApiResponseAsync(ForgeApiRequest<ChallengeList>(GetChallengeRealmLeaderboardUrl(realm)));
        }
    }
}
