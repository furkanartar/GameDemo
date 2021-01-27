using Entities;

namespace Business.Interfaces
{
    public interface ICampaignManager
    {
        void Add(Campaign campaing, Game game, Player player);
        void Delete(Campaign campaing, Player player);
        void Update(Campaign campaing, Game game, Player player);
    }
}