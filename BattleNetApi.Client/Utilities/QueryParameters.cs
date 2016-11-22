using System.Collections.Generic;
using System.Text;
using System.Web;

namespace BattleNetApi.Client.Utilities
{
    public class ApiQueryParameters
    {
        private readonly Dictionary<string, string> _parametersDictionary;

        public ApiQueryParameters()
        {
            _parametersDictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return !_parametersDictionary.ContainsKey(key) ? null : _parametersDictionary[key];
            }
            set
            {
                if (!_parametersDictionary.ContainsKey(key))
                    _parametersDictionary.Add(key, value);
                else
                    _parametersDictionary[key] = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var last = _parametersDictionary.Count;
            var cur = 0;
            foreach (var kv in _parametersDictionary)
            {
                sb.Append(HttpUtility.UrlEncode(kv.Key));
                sb.Append("=");
                sb.Append(HttpUtility.UrlEncode(kv.Value));
                if (last > ++cur)
                    sb.Append("&");
            }

            return sb.ToString();
        }
    }
}
