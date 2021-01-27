using Entities;

namespace DataAccess
{
    public interface ICampaignDal
    {
        void Add(Campaign campaign, Game game, Player player);
        void Delete(Campaign campaign, Player player);
        void Update(Campaign campaign, Game game, Player player);
    }
}