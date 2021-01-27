using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Business.Interfaces;
using DataAccess;
using Entities;

namespace Business.Classes
{
    public class PlayerManager:IPlayerService
    {
        PlayerDal _playerDal;
        EdevletServiceAdapter edevletServiceAdapter;

        public PlayerManager(PlayerDal playerDal, EdevletServiceAdapter edevletServiceAdapter)
        {
            _playerDal = playerDal;
            this.edevletServiceAdapter = edevletServiceAdapter;
        }

        public void Add(Player player)
        {

            if (edevletServiceAdapter.CheckIfRealPerson(player))
            {
                _playerDal.Add(player);
            }
            else
            {
                Console.WriteLine("Lütfen gerçek bir kişi ile tekrar deneyin.");
            }
        }

        public void Update(Player player)
        {
            _playerDal.Update(player);
        }

        public void Delete(Player player)
        {
            _playerDal.Delete(player);
        }
    }
}