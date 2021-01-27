using System;
using System.Runtime.InteropServices;
using Business.Interfaces;
using DataAccess;
using Entities;

namespace Business.Classes
{
    public class PlayerManager:IPlayerManager
    {
        PlayerDal playerDal = new PlayerDal();

        public void Add(Player player)
        {
            EdevletServiceAdapter edevletServiceAdapter = new EdevletServiceAdapter();

            if (edevletServiceAdapter.CheckIfRealPerson(player))
            {
                playerDal.Add(player);
            }
            else
            {
                Console.WriteLine("Lütfen gerçek bir kişi ile tekrar deneyin.");
            }
        }

        public void Update(Player player)
        {
            playerDal.Update(player);
        }

        public void Delete(Player player)
        {
            playerDal.Delete(player);
        }
    }
}