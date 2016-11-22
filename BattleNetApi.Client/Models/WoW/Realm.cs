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
using System.Linq;
using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RealmList : IApiEndpoint
    {
        [JsonProperty("realms")]
        public Realm[] Realms { get; set; }

        [JsonIgnore]
        private List<Realm> _connectedRealms;
        [JsonIgnore]
        public IEnumerable<Realm> ConnectedRealms {
            get
            {
                if (_connectedRealms != null)
                    return _connectedRealms;
                
                var connectedRealms = new List<Realm>();
                foreach (var realm in Realms)
                {
                    if (!connectedRealms.Any(c => c.ConnectedRealms.Intersect(realm.ConnectedRealms).Any()))
                        connectedRealms.Add(realm);
                }

                return _connectedRealms = connectedRealms;
            }
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Realm
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("population")]
        public string Population { get; set; }
        [JsonProperty("queue")]
        public bool Queue { get; set; }
        [JsonProperty("status")]
        public bool Status { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("connected_realms")]
        public string[] ConnectedRealms { get; set; }
    }
}
