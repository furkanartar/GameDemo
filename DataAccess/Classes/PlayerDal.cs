using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class PlayerDal : IPlayerDal
    {
        private List<Player> _players;

        public PlayerDal()
        {
            _players = new List<Player>()
            {
                new Player(){Id = 1, NationalityId = "12345678910", NickName = "ASosyalGNC01", FirstName = "Furkan", LastName = "ARTAR", DateOfBirth = new DateTime(1999,1,1), GameOwned = ""},
                new Player(){Id = 2, NationalityId = "12345678910", NickName = "Abuzer", FirstName = "Abuzer", LastName = "ARTAR", DateOfBirth = new DateTime(1975,12,19), GameOwned = ""},
                new Player(){Id = 3, NationalityId = "12345678910", NickName = "EmmiOglu", FirstName = "Sude", LastName = "ARTAR", DateOfBirth = new DateTime(1996,6,12), GameOwned = ""},
                new Player(){Id = 4, NationalityId = "12345678910", NickName = "Aslonny", FirstName = "Merve", LastName = "ARTAR", DateOfBirth = new DateTime(2004,4,13), GameOwned = ""},
                new Player(){Id = 5, NationalityId = "12345678910", NickName = "NeBlm", FirstName = "Ecem", LastName = "ARTAR", DateOfBirth = new DateTime(1998,5,2), GameOwned = ""}
            };
        }

        public void Add(Player player)
        {
            EdevletServiceAdapter edevletServiceAdapter = new EdevletServiceAdapter();
            if (edevletServiceAdapter.CheckIfRealPerson(player))
            {
                _players.Add(new Player() {Id = player.Id, NationalityId = player.NationalityId, NickName = player.NickName, FirstName = player.FirstName, LastName = player.FirstName, DateOfBirth = player.DateOfBirth});
                Console.WriteLine($"{player.NickName} mahlaslı oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine("Lütfen gerçek bir kişi ile tekrar deneyiniz.");
            }
        }

        public void Update(Player player)
        {
            foreach (var _player in _players)
            {
                if (player.NationalityId == _player.NationalityId)
                {
                    _player.NationalityId = player.NationalityId;
                    _player.NickName = player.NickName;
                    _player.FirstName = player.FirstName;
                    _player.LastName = player.LastName;
                    _player.DateOfBirth = player.DateOfBirth;
                }
            }
            Console.WriteLine($"{player.FirstName} isimli oyuncu güncellendi.");
        }

        public void Delete(Player player)
        {
            foreach (var _player in _players)
            {
                if (player.NationalityId == _player.NationalityId)
                {
                    _player.NationalityId = "DELETED";
                    _player.NickName = "DELETED";
                    _player.FirstName = "DELETED";
                    _player.LastName = "DELETED";
                    _player.DateOfBirth = DateTime.Now;
                }
            }
            Console.WriteLine($"{player.FirstName} isimli oyuncu silindi.");
        }

        public int PlayerCount()
        {
            return _players.Count;
        }

        public List<Player> GetAllPlayers()
        {
            return _players;
        }
    }
}