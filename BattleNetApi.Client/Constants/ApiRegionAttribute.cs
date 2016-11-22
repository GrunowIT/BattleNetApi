using System;

namespace BattleNetApi.Client.Constants
{
    public class ApiRegionAttribute : Attribute
    {
        public string BaseUrl { get; }

        internal ApiRegionAttribute(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
    }
}
