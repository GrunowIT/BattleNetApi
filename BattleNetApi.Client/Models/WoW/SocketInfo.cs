using Newtonsoft.Json;

namespace BattleNetApi.Client.Models.WoW
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SocketInfo
    {
        [JsonProperty("sockets")]
        public Socket[] Sockets { get; set; }
    }
}