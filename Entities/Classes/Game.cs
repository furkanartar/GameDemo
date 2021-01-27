using Entities.Interfaces;

namespace Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int UnitPrice { get; set; }

    }
}