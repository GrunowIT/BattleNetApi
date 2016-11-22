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
