using System.Collections.Generic;
using Entities;

namespace Business.Interfaces
{
    public interface ICampaignService
    {
        void Add(Campaign campaing);
        void Delete(Campaign campaing);
        void Update(Campaign campaing);
    }
}