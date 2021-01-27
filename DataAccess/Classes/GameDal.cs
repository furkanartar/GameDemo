using Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class GameDal : IGameDal
    {
        public void Buy(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.NickName} mahlaslı oyuncu tarafından satın alındı.");
        }

        public void Add(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} mahlaslı oyuncu tarafından eklendi");
        }

        public void Delete(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} mahlaslı oyuncu tarafından silindi");
        }

        public void Update(Game game, Player player)
        {
            Console.WriteLine($"{game.GameName} adlı oyun {player.FirstName} mahlaslı oyuncu tarafından güncellendi.");
        }
    }
}