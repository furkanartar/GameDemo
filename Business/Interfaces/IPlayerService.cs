using System.Collections.Generic;
using Entities;

namespace Business.Interfaces
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}