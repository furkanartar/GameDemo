using Business.Classes;
using Entities;
using System;

namespace ConsoleUI
{
    public class MenuManager
    {
        PlayerManager _playerManager = new PlayerManager();
        GameManager _gameManager =new GameManager();
        CampaignManager _campaignManager = new CampaignManager();
        short _choice;

        public void MenuStart()
        {
            bool IsMainMenuOpen = true;
            while (IsMainMenuOpen)
            {
                MainMenu();

                switch (_choice)
                {
                    case 1:
                        PlayerMainMenu();
                        switch (_choice)
                        {
                            case 1:
                                PlayerAddMenu();
                                break;

                            case 2:
                                PlayerUpdateMenu();
                                break;

                            case 3:
                                PlayerDeleteMenu();
                                break;

                            case 4:
                                Exit();
                                break;

                            default:
                                Console.WriteLine("Hatalı seçim.");
                                break;
                        }
                        break;

                    case 2:
                        GameMainMenu();
                        switch (_choice)
                        {
                            case 1:
                                GameAddMenu();
                                break;

                            case 2:
                                GameUpdateMenu();
                                break;

                            case 3:
                                GameDeleteMenu();
                                break;

                            case 4:
                                BuyGame();
                                break;
                            case 5:
                                Exit();
                                break;

                            default:
                                Console.WriteLine("Hatalı seçim.");
                                break;
                        }
                        break;

                    case 3:
                        CampaignMainMenu();
                        switch (_choice)
                        {
                            case 1:
                                CampaignAddMenu();
                                break;

                            case 2:
                                CampaignUpdateMenu();
                                break;

                            case 3:
                                CampaignDeleteMenu();
                                break;

                            case 4:
                                Exit();
                                break;

                            default:
                                Console.WriteLine("Hatalı seçim.");
                                break;
                        }
                        break;

                    case 4:
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim.");
                        break;
                }
            }
        }

        public void MainMenu()
        {
            Console.WriteLine("------------ ANA MENÜSÜ -----------");
            Console.WriteLine(" 1 - Oyuncu Menüsü");
            Console.WriteLine(" 2 - Oyun Menüsü");
            Console.WriteLine(" 3 - Kampanya Menüsü");
            Console.WriteLine(" 4 - Çıkış");
            Console.WriteLine("-----------------------------------");
            _choice = short.Parse(Console.ReadLine());
        }


        public void PlayerMainMenu()
        {
            Console.WriteLine("---------- OYUNCU MENÜSÜ ----------");
            Console.WriteLine(" 1 - Oyuncu Ekleme");
            Console.WriteLine(" 2 - Oyuncu Güncelleme");
            Console.WriteLine(" 3 - Oyuncu Silme");
            Console.WriteLine(" 4 - Çıkış");
            Console.WriteLine("-----------------------------------");
            _choice = short.Parse(Console.ReadLine());
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
            Player player = new Player() {NationalityId = nationalityId, FirstName = firstName, LastName = lastName, NickName = nickName, DateOfBirth = dateOfBirth };
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
            Console.WriteLine(" 4 - Oyun Alma");
            Console.WriteLine(" 5 - Çıkış");
            Console.WriteLine("-----------------------------------");
            _choice = short.Parse(Console.ReadLine());
        }
        public void GameAddMenu()
        {
            Console.Write("\n" + "\n" + "Mahlasınız: ");
            string nickName = Console.ReadLine();
            Console.WriteLine("Oyun bilgilerini sırayla giriniz: ");
            Console.Write("Oyun adı: ");
            string gameName = Console.ReadLine();
            Console.Write("Oyunun açıklaması: ");
            string gameDescription = Console.ReadLine();
            Console.Write("Oyunun fiyatı: ");
            int unitPrice = int.Parse(Console.ReadLine());

            Player player = new Player() { NickName = nickName };
            Game game = new Game() {GameName = gameName, GameDescription = gameDescription, UnitPrice = unitPrice };
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
            Player player = new Player() { NickName = nickName };
            Game game = new Game() { GameName = gameName, GameDescription = "asd", Id = 5, UnitPrice = 5 };
            _gameManager.Update(game, player);
        }
        public void GameDeleteMenu()
        {
            Console.WriteLine("\n" + "\n" + "Silmek istediğiniz oyunun bilgilerini giriniz:");
            Console.Write("Oyun adı: ");
            string gameName = Console.ReadLine();
            Console.Write("Mahlasınız: ");
            string nickName = Console.ReadLine();
            Game game = new Game() { GameName = gameName };
            Player player = new Player() { NickName = nickName };
            _gameManager.Delete(game, player);
        }
        public void BuyGame()
        {
            Console.WriteLine("Mahlasınızı giriniz:");
            string nickName = Console.ReadLine();
            Console.WriteLine("Satın almak istediğiniz oyunun Id'sini giriniz: ");
            int id = int.Parse(Console.ReadLine());
            Player player = new Player() { NickName = nickName };
            Game game = new Game() { Id = id };
            _gameManager.Buy(game, player);
        }


        public void CampaignMainMenu()
        {
            Console.WriteLine("---------- Kampanya MENÜSÜ ----------");
            Console.WriteLine(" 1 - Kampanya Ekleme");
            Console.WriteLine(" 2 - Kampanya Güncelleme");
            Console.WriteLine(" 3 - Kampanya Silme");
            Console.WriteLine(" 4 - Çıkış");
            Console.WriteLine("-----------------------------------");
            _choice = short.Parse(Console.ReadLine());
        }
        public void CampaignAddMenu()
        {
            Console.WriteLine("\n" + "\n" + "Kampanya bilgilerini sırayla giriniz: ");
            Console.Write("Oyunun Id'si: ");
            int gameId = int.Parse(Console.ReadLine());
            Console.Write("Kampanya oranı: ");
            int discountRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Kampanya başlığı: ");
            string title = Console.ReadLine();

            Campaign campaign = new Campaign() {GameID = gameId, DiscountRate = discountRate, Title = title };
            _campaignManager.Add(campaign);
        }
        public void CampaignUpdateMenu()
        {
            Console.WriteLine("\n" + "\n" + "Güncellemek istediğiniz Kampanyanın Id'sini giriniz: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + "\n" + "Kampanyanın güncel bilgilerini sırayla giriniz: ");
            Console.Write("Oyun Id'si: ");
            int gameId = int.Parse(Console.ReadLine());
            Console.Write("İndirim oranı: ");
            int discountRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Kampanya başlığı: ");
            string title = Console.ReadLine();

            Campaign campaign = new Campaign() { Id = id, GameID = gameId, DiscountRate = discountRate, Title = title };
            _campaignManager.Add(campaign);
        }
        public void CampaignDeleteMenu()
        {
            Console.WriteLine("\n" + "\n" + "Silmek istediğiniz Kampanyanın Id'sini giriniz: ");
            int id = int.Parse(Console.ReadLine());

            Campaign campaign = new Campaign() { Id = id };
            _campaignManager.Add(campaign);
        }


        public void Exit()
        {
            Console.WriteLine("Eğer bu projeye beni işe almak için bakıyorsanız şunu belirtmek istiyorum. Proje sadece simule kodları barındırıyor. Hata yakalama, gerçek iş kodu gibi işlemleri barındırmıyor.");
            Environment.Exit(0);
        }
    }
}