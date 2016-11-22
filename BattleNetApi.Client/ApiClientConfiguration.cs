using System;
using BattleNetApi.Client.Constants;
using BattleNetApi.Client.Extensions;
using BattleNetApi.Client.Networking;

namespace BattleNetApi.Client
{
    public class ApiClientConfiguration
    {
        private Region _region;
        
        public TimeSpan ApiWaitingTimeSpan { get; }
        public Uri BaseUri { get; private set; }
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
        public int MaxRequestsPerTimeSpan;
        public TimeSpan PerTimeSpan;

        public ApiClientConfiguration(Region region = Region.US, Locale locale = Locale.en_US,
            int maxRequestsPerTimeSpan = 50, TimeSpan? perTimeSpan = null, TimeSpan? apiWaitingTimeSpan = null)
        {
            Region = region;
            Locale = locale;
            MaxRequestsPerTimeSpan = maxRequestsPerTimeSpan;
            PerTimeSpan = perTimeSpan ?? TimeSpan.FromSeconds(1);
            ApiWaitingTimeSpan = apiWaitingTimeSpan ?? TimeSpan.FromSeconds(30);
        }
    }
}
