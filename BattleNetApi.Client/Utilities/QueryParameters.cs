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
