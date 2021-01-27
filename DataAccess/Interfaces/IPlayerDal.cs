using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public interface IPlayerDal
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
        int PlayerCount();
        List<Player> GetAllPlayers();
    }
}