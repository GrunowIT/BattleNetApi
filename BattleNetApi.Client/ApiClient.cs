using System;
using BattleNetApi.Client.Models;
using BattleNetApi.Client.Networking;
using BattleNetApi.Client.Utilities;

namespace BattleNetApi.Client
{
    public sealed partial class ApiClient
    {
        public ApiClientConfiguration ClientConfiguration { get; }
        private ApiProvider ApiProvider { get; }

        private string ApiKey { get; }

        public ApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null)
        {
            ApiKey = apiKey;
            ClientConfiguration = clientConfiguration ?? new ApiClientConfiguration();

            ApiProvider = new ApiProvider(ClientConfiguration.MaxRequestsPerTimeSpan, ClientConfiguration.PerTimeSpan);
        }

        public Uri GetEndpointUri(string relativePath, ApiQueryParameters queryParameters = null)
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

        public ApiRequest<T> ForgeApiRequest<T>(string relativeEndpointUri, ApiQueryParameters apiQueryParameters = null) where T : IApiEndpoint
        {
            return new ApiRequest<T>(GetEndpointUri(relativeEndpointUri, apiQueryParameters));
        }

        public T GetApiResponse<T>(ApiRequest<T> apiRequest) where T : IApiEndpoint
        {
            var apiResponse = ApiProvider.MakeRequestAsync(apiRequest);
            apiResponse.Wait(ClientConfiguration.ApiWaitingTimeSpan);

            if (apiResponse.Exception != null)
                throw apiResponse.Exception;
            if (apiResponse.Result == null)
                throw new Exception("Unknown error occured. Result is NULL.");

            return apiResponse.Result;
        }
    }
}
