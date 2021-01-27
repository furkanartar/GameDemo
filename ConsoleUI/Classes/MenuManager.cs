using Business.Classes;
using Entities;
using System;
using System.Collections.Generic;
using DataAccess;

namespace ConsoleUI
{
    public class MenuManager
    {
        PlayerManager _playerManager = new PlayerManager();
        private GameManager _gameManager = new GameManager();
        short _select;
        private int _id = 4;

        public void MainMenu()
        {
            Console.WriteLine("------------ ANA MENÜSÜ -----------");
            Console.WriteLine(" 1 - Oyuncu Menüsü");
            Console.WriteLine(" 2 - Oyun Menüsü");
            Console.WriteLine(" 3 - Çıkış");
            Console.WriteLine("-----------------------------------");
            _select = short.Parse(Console.ReadLine());
        }
        public void PlayerMainMenu()
        {
            Console.WriteLine("---------- OYUNCU MENÜSÜ ----------");
            Console.WriteLine(" 1 - Oyuncu Ekleme");
            Console.WriteLine(" 2 - Oyuncu Güncelleme");
            Console.WriteLine(" 2 - Oyuncu Silme");
            Console.WriteLine(" 3 - Çıkış");
            Console.WriteLine("-----------------------------------");
            _select = short.Parse(Console.ReadLine());
        }
        public void PlayerAddMenu()
        {
            Console.WriteLine("\n" + "\n" + "Oyuncu bilgilerini sırayla giriniz: ");
            Console.Write("Kimlik numarası: ");
            string nationalityId = Console.ReadLine();
            Console.Write("Adı: ");
            string firstName = Console.ReadLine();
            Console.Write("Soyadı: ");
            string lastName = Console.ReadLine();
            Console.Write("Mahlasınız: ");
            string nickName = Console.ReadLine();
            DateTime dateOfBirth = new DateTime();
            Console.Write("Doğum yılınız: ");
            string year = Console.ReadLine();
            Console.Write("Doğum ayınız: ");
            string month = Console.ReadLine();
            Console.Write("Doğum gününüz: ");
            string day = Console.ReadLine();
            string allofdate = $"{year} {month} {day}";
            dateOfBirth = DateTime.Parse(allofdate);
            Console.WriteLine(dateOfBirth);
            Player player = new Player() { Id = _id++, NationalityId = nationalityId, FirstName = firstName, LastName = lastName, NickName = nickName, DateOfBirth = dateOfBirth };
            _playerManager.Add(player);
        }
        public void PlayerUpdateMenu()
        {
            Console.Write("\n" + "\n" + "Güncellemek istediğiniz oyuncunun kimlik numarası: ");
            string nationalityId = Console.ReadLine();
            Console.WriteLine("Sıradaki bilgileri güncellemek istediğiniz şekilde giriniz");
            Console.Write("Ad: ");
            string firstName = Console.ReadLine();
            Console.Write("Soyad: ");
            string lastName = Console.ReadLine();
            Console.Write("Mahlas: ");
            string nickName = Console.ReadLine();
            Player player = new Player() { NationalityId = nationalityId, FirstName = firstName, LastName = lastName, NickName = nickName };
            _playerManager.Update(player);
        }
        public void PlayerDeleteMenu()
        {
            Console.WriteLine("\n" + "\n" + "Silmek istediğiniz oyuncunun bilgilerini giriniz:");
            Console.Write("Kimlik numarası: ");
            string nationalityId = Console.ReadLine();
            Console.Write("Mahlasınız: ");
            string nickName = Console.ReadLine();
            Player player = new Player() { NationalityId = nationalityId, NickName = nickName };
            _playerManager.Delete(player);
        }

        public void GameMainMenu()
        {
            Console.WriteLine("---------- OYUN MENÜSÜ ----------");
            Console.WriteLine(" 1 - Oyun Ekleme");
            Console.WriteLine(" 2 - Oyun Güncelleme");
            Console.WriteLine(" 3 - Oyun Silme");
            Console.WriteLine(" 4 - Oyunları listele"); //YAZILMADI
            Console.WriteLine(" 5 - Çıkış"); // YAZILMADI
            Console.WriteLine("-----------------------------------");
            _select = short.Parse(Console.ReadLine());
        }
        public void GameAddMenu()
        {
            Console.Write("Mahlasınız: ");
            string nickName = Console.ReadLine();
            Console.WriteLine("\n" + "\n" + "Oyun bilgilerini sırayla giriniz: ");
            Console.Write("Oyun adı: ");
            string gameName = Console.ReadLine();
            Console.Write("Oyunun açıklaması: ");
            string gameDescription = Console.ReadLine();
            Console.Write("Oyunun fiyatı: ");
            int unitPrice = int.Parse(Console.ReadLine());

            Player player = new Player() {NickName = nickName};
            Game game = new Game() {Id = _id++, GameName = gameName, GameDescription = gameDescription, UnitPrice = unitPrice};
            _gameManager.Add(game, player);
        }
        public void GameUpdateMenu()
        {
            Console.Write("\n" + "\n" + "Güncellemek istediğiniz oyunun adı: ");
            string gameName = Console.ReadLine();
            Console.WriteLine("Mahlasınız nedir?");
            string nickName = Console.ReadLine();
            Console.WriteLine("Sıradaki bilgileri güncellemek istediğiniz şekilde giriniz");
            Console.Write("Oyunun Açıklaması: ");
            string gameDescription = Console.ReadLine();
            Console.Write("Oyunun Fiyatı: ");
            string UnitPrice = Console.ReadLine();
            Player player = new Player() {NickName = nickName};
            Game game = new Game() {GameName = gameName, GameDescription = "asd", Id = 5, UnitPrice = 5};
            _gameManager.Update(game, player);
        }
        public void GameDeleteMenu()
        {
            Console.WriteLine("\n" + "\n" + "Silmek istediğiniz oyunun bilgilerini giriniz:");
            Console.Write("Oyun adı: ");
            string gameName = Console.ReadLine();
            Console.Write("Mahlasınız: ");
            string nickName = Console.ReadLine();
            Game game = new Game() { GameName = gameName};
            Player player = new Player() { NickName = nickName};
            _gameManager.Delete(game, player);
        }
        public void GameList(List<Game> games)
        {

        }





        public void Exit()
        {
            this.Exit();
        }

    }
}