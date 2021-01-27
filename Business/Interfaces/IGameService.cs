using System.Collections.Generic;
using Entities;

namespace Business.Interfaces
{
    public interface IGameService
    {
        void Buy(Game game, Player player);
        void Add(Game game, Player player);
        void Delete(Game game, Player player);
        void Update(Game game, Player player);
    }
}