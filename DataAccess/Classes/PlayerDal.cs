using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class PlayerDal : IPlayerDal
    {
        public void Add(Player player)
        {
            Console.WriteLine($"{player.FirstName} isimli oyuncu eklendi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine($"{player.FirstName} isimli oyuncu güncellendi.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine($"{player.FirstName} isimli oyuncu silindi.");
        }
    }
}