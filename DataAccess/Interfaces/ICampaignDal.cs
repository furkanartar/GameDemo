using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public interface ICampaignDal
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        int CampaignCount();
        List<Campaign> GetAllCampaigns();
    }
}