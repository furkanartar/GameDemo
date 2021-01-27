using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class CampaignDal : ICampaignDal
    {
        List<Campaign> _campaigns;
        private GameDal _gameDal = new GameDal();
        
        public CampaignDal()
        {
            _campaigns = new List<Campaign>()
            {
                new Campaign() {Id = 1, GameID = 1, Title = "ÜCRETSİZ NOEL KOSTÜMÜ", DiscountRate = 0},
                new Campaign() {Id = 2, GameID = 3, Title = "ÜCRETSİZ AWP SKİNİ", DiscountRate = 0},
                new Campaign() {Id = 3, GameID = 1, Title = "%75 İNDİRİM!", DiscountRate = 0},
                new Campaign() {Id = 4, GameID = 2, Title = "%25 İNDİRİM!", DiscountRate = 25}
            };
        }

        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
            Console.WriteLine($"{campaign.Title} adlı kampanyayı ekledi.");

        }

        public void Update(Campaign campaign)
        {
            foreach (var _campaign in _campaigns)
            {
                if (_campaign.Id != campaign.Id)
                {
                    _campaign.GameID = campaign.Id;
                    _campaign.Title = campaign.Title;
                    _campaign.DiscountRate = campaign.DiscountRate;
                }
            }
            Console.WriteLine($"{campaign.Title} adlı kampanya güncellendi.");
        }

        public void Delete(Campaign campaign)
        {
            foreach (var _campaign in _campaigns)
            {
                if (_campaign.Id != campaign.Id)
                {
                    _campaign.GameID = 0;
                    _campaign.Title = "DELETED";
                    _campaign.DiscountRate = 0;
                }
            }
            Console.WriteLine($"{campaign.Title} adlı kampanyayı sildi.");

        }

        public List<Campaign> GetAllCampaigns()
        {
            return _campaigns;
        }

        public int CampaignCount()
        {
            return _campaigns.Count;
        }

        //public double DiscountedGamePrice(int gameId, double campaignDiscountedRate)
        //{
        //    double gamePrice = 0;
        //    foreach (var game in _gameDal.GetAllGames())
        //    {
        //        if (gameId != game.Id)
        //        {
        //            gamePrice = (game.UnitPrice / 100) * (100 - campaignDiscountedRate);
        //        }
        //    }
        //    return gamePrice;
        //}
    }
}