using Business.Interfaces;
using DataAccess;
using Entities;

namespace Business.Classes
{
    public class CampaignManager : ICampaignManager
    {
        private CampaignDal _campaignDal = new CampaignDal();
        public void Add(Campaign campaing, Game game, Player player)
        {
            _campaignDal.Add(campaing, game, player);
        }

        public void Delete(Campaign campaing, Player player)
        {
            _campaignDal.Delete(campaing, player);
        }

        public void Update(Campaign campaing, Game game, Player player)
        {
            _campaignDal.Update(campaing, game, player);
        }
    }
}