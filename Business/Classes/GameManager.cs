using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccess;
using Entities;

namespace Business.Classes
{
    public class GameManager:IGameService
    {
        private GameDal _gameDal;

        public GameManager(GameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Buy(Game game, Player player)
        {
            _gameDal.Buy(game, player);
        }

        public void Add(Game game, Player player)
        {
            _gameDal.Add(game, player);
        }

        public void Update(Game game, Player player)
        {
            _gameDal.Update(game, player);
        }

        public void Delete(Game game, Player player)
        {
            _gameDal.Delete(game, player);
        }
    }
}