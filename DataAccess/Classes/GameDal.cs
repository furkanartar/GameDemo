using Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class GameDal : IGameDal
    {
        List<Game> _games;

        public GameDal()
        {
            new List<Game>()
                {
                    new Game() {Id = 1, GameName = "Metin2", GameDescription = "FREE TO PLAY! MMORPG", UnitPrice = 0},
                    new Game() {Id = 2, GameName = "Sid Meier's Civilization VI", GameDescription = "STRATEGY", UnitPrice = 60},
                    new Game() {Id = 3, GameName = "Counter Strike : Global Offensive", GameDescription = "FREE TO PLAY! FPS", UnitPrice = 0}
                };
        }

        public void Buy(Game game, Player player)
        {
            PlayerDal playerDal = new PlayerDal(); 
            foreach (var _player in playerDal.GetPlayers())
            {
                if (player.NationalityId == _player.NationalityId)
                {
                    _player.GameOwned += game.GameName;
                }
                else
                {
                    Console.WriteLine("Böyle bir oyuncu yok.");
                }
            }
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} adlı oyuncu tarafından satın alındı.");
        }

        public void Add(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} adlı oyuncu tarafından eklendi");
        }

        public void Delete(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} adlı oyuncu tarafından silindi");
        }

        public void Update(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} adlı oyuncu tarafından güncellendi.");
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}