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
}