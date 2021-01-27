using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class CampaignDal : ICampaignDal
    {
        List<Campaign> campaigns;
        private GameDal _gameDal = new GameDal();
        
        public CampaignDal()
        {
            campaigns = new List<Campaign>()
            {
                new Campaign() {Id = 1, GameID = 1, Title = "ÜCRETSİZ NOEL KOSTÜMÜ", DiscountRate = 0},
                new Campaign() {Id = 2, GameID = 3, Title = "ÜCRETSİZ AWP SKİNİ", DiscountRate = 0},
                new Campaign() {Id = 3, GameID = 1, Title = "%75 İNDİRİM!", DiscountRate = 0},
                new Campaign() {Id = 4, GameID = 2, Title = "%25 İNDİRİM!", DiscountRate = 25}
            };
        }

        public void Add(Campaign campaing, Game game, Player player)
        {
            //Business code.
            Console.WriteLine($"{player.NickName} mahlaslı oyuncu {campaing.Title} adlı kampanyayı {game.GameName} adlı oyun için ekledi.");
        }

        public void Delete(Campaign campaing, Player player)
        {
            //Business code.
            Console.WriteLine($"{player.NickName} mahlaslı oyuncu {campaing.Title} adlı kampanyayı sildi.");
        }

        public void Update(Campaign campaing, Game game, Player player)
        {
            //Business code.
            Console.WriteLine($"{player.NickName} mahlaslı oyuncu {campaing.Title} adlı kampanyayı güncelledi.");
        }

        public double DiscountedGamePrice(int gameId, double campaignDiscountedRate)
        {
            double gamePrice = 0;
            foreach (var game in _gameDal.GetAllGames())
            {
                if (gameId != game.Id)
                {
                    gamePrice = (game.UnitPrice / 100) * (100 - campaignDiscountedRate);
                }
            }
            return gamePrice;
        }
    }
}