using System;
using BattleNetApi.Client.Constants;
using BattleNetApi.Client.Extensions;
using BattleNetApi.Client.Models;
using BattleNetApi.Client.Networking;
using BattleNetApi.Client.Utilities;

namespace BattleNetApi.Client
{
    public sealed partial class ApiClient
    {
        private Region _region;
        private string ApiKey { get; }
        private ApiProvider ApiProvider { get; }
        private TimeSpan ApiWaitingTimeSpan { get; }

        private Uri BaseUri { get; set; }

        public Region Region
        {
            get { return _region; }
            set
            {
                _region = value;
                BaseUri = new Uri(value.GetBaseUrl());
            }
        }
        public Locale Locale { get; set; }

        public ApiClient(string apiKey, Region region = Region.US, Locale locale = Locale.en_US, TimeSpan? apiWaitingTimeSpan = null)
        {
            ApiKey = apiKey;
            Region = region;
            Locale = locale;
            ApiProvider = new ApiProvider(50, TimeSpan.FromSeconds(1));
            ApiWaitingTimeSpan = apiWaitingTimeSpan ?? TimeSpan.FromSeconds(30);
        }

        public Uri GetEndpointUri(string relativePath, ApiQueryParameters queryParameters = null)
        {
            if (queryParameters == null)
                queryParameters = new ApiQueryParameters();

            if (string.IsNullOrWhiteSpace(queryParameters["locale"]))
                queryParameters["locale"] = Locale.ToString();
            if (string.IsNullOrWhiteSpace(queryParameters["apikey"]))
                queryParameters["apikey"] = ApiKey;

            var endpointUri = new Uri(BaseUri, string.Concat(relativePath, "?", queryParameters));
            return endpointUri;
        }

        public T GetApiResponse<T>(ApiRequest<T> apiRequest) where T : IApiEndpoint
        {
            var apiResponse = ApiProvider.MakeRequestAsync(apiRequest);
            apiResponse.Wait(ApiWaitingTimeSpan);

            if (apiResponse.Exception != null)
                throw apiResponse.Exception;
            if (apiResponse.Result == null)
                throw new Exception("Unknown error occured. Result is NULL.");

            return apiResponse.Result;
        }
    }
}
