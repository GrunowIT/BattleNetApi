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

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleNetApi.Client.Models;
using BattleNetApi.Client.Utilities;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Networking
{
    public class ApiProvider
    {
        private readonly TimeThrottledQueue _apiQueue;

        public ApiProvider(int maxActions, TimeSpan perTimeSpan)
        {
            _apiQueue = new TimeThrottledQueue(maxActions, perTimeSpan);
        }

        public Task<T> MakeRequestAsync<T>(ApiRequest<T> apiRequest) where T : IApiEndpoint
        {
            return _apiQueue.Enqueue(() => GetFromJson(apiRequest), CancellationToken.None);
        }

        public static T GetFromJson<T>(ApiRequest<T> apiRequest) where T : IApiEndpoint
        {
            var webRequest = WebRequest.CreateHttp(apiRequest.RequestUri);
            var response = webRequest.GetResponse();
            var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            var jsonContent = reader.ReadToEnd();
            var result = JsonConvert.DeserializeObject<T>(jsonContent);
            return result;
        }
    }
}
