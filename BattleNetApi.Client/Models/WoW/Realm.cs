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
