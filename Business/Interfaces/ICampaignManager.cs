using System.Collections.Generic;
using Entities;

namespace Business.Interfaces
{
    public interface ICampaignManager
    {
        void Add(Campaign campaing);
        void Delete(Campaign campaing);
        void Update(Campaign campaing);
        int CampaignCount();
        List<Campaign> GetAllCampaigns();
    }
}