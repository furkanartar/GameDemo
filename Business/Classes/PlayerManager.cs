using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Business.Interfaces;
using DataAccess;
using Entities;

namespace Business.Classes
{
    public class PlayerManager:IPlayerManager
    {
        PlayerDal _playerDal = new PlayerDal();

        public void Add(Player player)
        {
            EdevletServiceAdapter edevletServiceAdapter = new EdevletServiceAdapter();

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

        public int PlayerCount()
        {
            return _playerDal.PlayerCount();
        }

        public List<Player> GetAllPlayers()
        {
            return _playerDal.GetAllPlayers();
        }
    }
}