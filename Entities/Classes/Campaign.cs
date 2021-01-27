using Entities.Interfaces;

namespace Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GameID { get; set; }
        public double DiscountRate{ get; set; }
        public double DiscountedPrice { get; set; }
    }
}