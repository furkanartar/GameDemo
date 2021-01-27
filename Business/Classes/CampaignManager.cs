using Business.Interfaces;
using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Business.Classes
{
    public class CampaignManager : ICampaignService
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
    }
}