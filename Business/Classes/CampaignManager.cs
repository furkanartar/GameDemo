using System.Collections.Generic;
using Business.Interfaces;
using DataAccess;
using Entities;

namespace Business.Classes
{
    public class CampaignManager : ICampaignManager
    {
        private CampaignDal _campaignDal = new CampaignDal();
        public void Add(Campaign campaing)
        {
            _campaignDal.Add(campaing);
        }
        public void Update(Campaign campaing)
        {
            _campaignDal.Update(campaing);
        }
        public void Delete(Campaign campaing)
        {
            _campaignDal.Delete(campaing);
        }

        public int CampaignCount()
        {
            return _campaignDal.CampaignCount();
        }

        public List<Campaign> GetAllCampaigns()
        {
            return _campaignDal.GetAllCampaigns();
        }
    }
}