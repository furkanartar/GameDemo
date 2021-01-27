using System;
using Entities.Interfaces;

namespace Entities
{
    public class Player:IEntity
    {
        public int  Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GameOwned { get; set; }
    }
}