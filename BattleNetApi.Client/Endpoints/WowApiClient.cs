namespace BattleNetApi.Client.Endpoints
{
    public partial class WowApiClient : ApiClient
    {
        internal WowApiClient(string apiKey, ApiClientConfiguration clientConfiguration = null) : base(apiKey, clientConfiguration)
        {
        }
    }
}
