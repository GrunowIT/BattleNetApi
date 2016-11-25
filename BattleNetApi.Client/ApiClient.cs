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
using System.Threading.Tasks;
using BattleNetApi.Client.Models;
using BattleNetApi.Client.Networking;
using BattleNetApi.Client.Utilities;

namespace BattleNetApi.Client
{
    public class ApiClient
    {
        public ApiClientConfiguration ClientConfiguration { get; }
        private ApiProvider ApiProvider { get; }

        private string ApiKey { get; }
        private string ClientId { get; }
        private string ClientSecret { get; }

        /// <summary>
        /// Creates a new instance of an ApiClient.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientConfiguration"></param>
        /// <param name="clientId">ClientID required for OAuth, otherwise optional.</param>
        /// <param name="clientSecret">ClientSecret required for OAuth, otherwise optional.</param>
        public ApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null, string clientId = null, string clientSecret = null)
        {
            ApiKey = apiKey;
            ClientConfiguration = clientConfiguration ?? new ApiClientConfiguration();
            ClientId = clientId;
            ClientSecret = clientSecret;

            ApiProvider = new ApiProvider(ClientConfiguration.MaxRequestsPerTimeSpan, ClientConfiguration.PerTimeSpan);
        }

        private WowApiClient _wowApiClient;
        public WowApiClient WoW => _wowApiClient ?? (_wowApiClient = new WowApiClient(ApiKey, ClientConfiguration));

        private D3ApiClient _d3ApiClient;
        public D3ApiClient D3 => _d3ApiClient ?? (_d3ApiClient = new D3ApiClient(ApiKey, ClientConfiguration));

        private Sc2ApiClient _sc2ApiClient;
        public Sc2ApiClient SC2 => _sc2ApiClient ?? (_sc2ApiClient = new Sc2ApiClient(ApiKey, ClientConfiguration));

        private OauthApiClient _oauthApiClient;
        public OauthApiClient OAuth => _oauthApiClient ?? (_oauthApiClient = new OauthApiClient(ApiKey, ClientId, ClientSecret, ClientConfiguration));

        protected Uri GetEndpointUri(string relativePath, ApiQueryParameters queryParameters = null)
        {
            if (queryParameters == null)
                queryParameters = new ApiQueryParameters();

            if (string.IsNullOrWhiteSpace(queryParameters["locale"]))
                queryParameters["locale"] = ClientConfiguration.Locale.ToString();
            if (string.IsNullOrWhiteSpace(queryParameters["apikey"]))
                queryParameters["apikey"] = ApiKey;

            var endpointUri = new Uri(ClientConfiguration.BaseUri, string.Concat(relativePath, "?", queryParameters));
            return endpointUri;
        }

        protected ApiRequest<T> ForgeApiRequest<T>(string relativeEndpointUri, ApiQueryParameters apiQueryParameters = null) where T : IApiEndpoint
        {
            return new ApiRequest<T>(GetEndpointUri(relativeEndpointUri, apiQueryParameters));
        }

        protected T GetApiResponse<T>(ApiRequest<T> apiRequest) where T : IApiEndpoint
        {
            var apiResponse = ApiProvider.MakeRequestAsync(apiRequest);
            apiResponse.Wait(ClientConfiguration.ApiWaitingTimeSpan);

            if (apiResponse.Exception != null)
                throw apiResponse.Exception;
            if (apiResponse.Result == null)
                throw new Exception("Unknown error occured. Result is NULL.");

            return apiResponse.Result;
        }

        protected async Task<T> GetApiResponseAsync<T>(ApiRequest<T> apiRequest) where T : IApiEndpoint
        {
            return await ApiProvider.MakeRequestAsync(apiRequest);
        }
    }

    public sealed partial class WowApiClient : ApiClient
    {
        internal WowApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null) : base(apiKey, clientConfiguration)
        {
        }
    }

    public sealed partial class D3ApiClient : ApiClient
    {
        internal D3ApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null) : base(apiKey, clientConfiguration)
        {
        }
    }

    public sealed partial class Sc2ApiClient : ApiClient
    {
        internal Sc2ApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null) : base(apiKey, clientConfiguration)
        {
        }
    }

    public sealed partial class OauthApiClient : ApiClient
    {
        internal OauthApiClient(string apiKey, string clientId, string clientSecret, ApiClientConfiguration clientConfiguration = null) : base(apiKey, clientConfiguration, clientId, clientSecret)
        {
        }
    }
}
