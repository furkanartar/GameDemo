using Entities;

namespace DataAccess
{
    public interface ICampaignDal
    {
        void Add(Campaign campaing, Game game, Player player);
        void Delete(Campaign campaing, Player player);
        void Update(Campaign campaing, Game game, Player player);
    }
}