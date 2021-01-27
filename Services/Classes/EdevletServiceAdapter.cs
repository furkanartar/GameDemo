using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class EdevletServiceAdapter : IEdevletServiceAdapter
    {
        private List<Player> players;
        public EdevletServiceAdapter()
        {
            new List<Player>()
            {
                new Player() {Id = 1, FirstName = "Furkan", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(1999,1,1)},
                new Player() {Id = 2, FirstName = "Abuzer", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(1975,12,19)},
                new Player() {Id = 3, FirstName = "Sude", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(1996,6,12)},
                new Player() {Id = 4, FirstName = "Merve", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(2004,4,13)},
                new Player() {Id = 5, FirstName = "Ecem", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(1998,5,24)},
                new Player() {Id = 6, FirstName = "Furkan", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(1976,1,1)},
                new Player() {Id = 7, FirstName = "Eda", LastName = "ARTAR", NationalityId = "12345678910", DateOfBirth = new DateTime(1996,4,26)},
                new Player() {Id = 8, FirstName = "Sude", LastName = "KOZALIOĞLU", NationalityId = "12345678910", DateOfBirth = new DateTime(1970,6,6)}
            };
        }

        public bool CheckIfRealPerson(Player player)
        {
            bool RealPerson = true;
            foreach (var player1 in players)
            {
                if (player1.NationalityId == player.NationalityId && player1.FirstName == player.FirstName && player1.LastName == player.LastName && player1.DateOfBirth == player.DateOfBirth)
                {
                    RealPerson = true;
                }
                else
                {
                    RealPerson = false;
                }
            }
            return RealPerson;
        }
    }
}