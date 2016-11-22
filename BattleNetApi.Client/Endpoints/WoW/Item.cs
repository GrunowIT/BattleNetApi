using BattleNetApi.Client.Models.WoW;

namespace BattleNetApi.Client
{
    public partial class ApiClient
    {
        public Item GetItem(int itemId)
        {
            return GetApiResponse(ForgeApiRequest<Item>($"/wow/item/{itemId}"));
        }

        public ItemSet GetItemSet(int setId)
        {
            return GetApiResponse(ForgeApiRequest<ItemSet>($"/wow/item/set/{setId}"));
        }
    }
}
