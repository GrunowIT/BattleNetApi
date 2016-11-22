using System;
using BattleNetApi.Client.Models;

namespace BattleNetApi.Client.Networking
{
    public class ApiRequest<T> where T : IApiEndpoint
    {
        public ApiRequest(Uri requestUri)
        {
            RequestUri = requestUri;
        }

        public Uri RequestUri { get; }
    }
}
