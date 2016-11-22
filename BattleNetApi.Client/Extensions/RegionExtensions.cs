using System;
using System.Reflection;
using BattleNetApi.Client.Constants;

namespace BattleNetApi.Client.Extensions
{
    public static class RegionExtensions
    {
        public static string GetBaseUrl(this Region r)
        {
            var attrib = GetAttribute(r);
            return attrib.BaseUrl;
        }

        private static ApiRegionAttribute GetAttribute(Region r)
        {
            return (ApiRegionAttribute) Attribute.GetCustomAttribute(ForValue(r), typeof(ApiRegionAttribute));
        }

        private static MemberInfo ForValue(Region r)
        {
            return typeof(Region).GetField(Enum.GetName(typeof(Region), r));
        }
    }
}
