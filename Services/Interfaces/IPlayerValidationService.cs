using Entities;

namespace DataAccess
{
    public interface IPlayerValidationService
    {
        bool CheckIfRealPerson(Player player);
    }
}