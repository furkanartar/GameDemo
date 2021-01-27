using System.Collections.Generic;
using Entities;

namespace Business.Interfaces
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
        int PlayerCount();
        List<Player> GetAllPlayers();
    }
}