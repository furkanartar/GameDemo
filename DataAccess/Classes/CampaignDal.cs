using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class CampaignDal : ICampaignDal
    {
        private GameDal _gameDal = new GameDal();
        
        public void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Title} adlı kampanyayı ekledi.");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Title} adlı kampanya güncellendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Title} adlı kampanyayı sildi.");

        }
    }
}