namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient : ApiClient
    {
        public WowApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null) : base(apiKey, clientConfiguration)
        {
        }
    }
}
