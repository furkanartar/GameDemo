using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class PlayerValidationManager : IPlayerValidationService
    {
        private List<Player> players;

        public bool CheckIfRealPerson(Player player)
        {
            bool RealPerson = true;
            
                if ("12345678910" == player.NationalityId && "FURKAN" == player.FirstName && "ARTAR" == player.LastName)
                {
                    RealPerson = true;
                }
                else
                {
                    RealPerson = false;
                }
            return RealPerson;
        }
    }
}