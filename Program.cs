using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                FirstName = "Merve",
                LastName = "Kardeş",
                TcNo = "12345678910",
                YearOfBirth = 1998
            };
            Gamer gamer2 = new Gamer
            {
                FirstName = "Meral",
                LastName = "Kardeş",
                TcNo = "12345678911",
                YearOfBirth = 1993
            };

            Game game1 = new Game { Id = 1, Name = "Fifa", Price = 100 };
            Game game2 = new Game { Id = 2, Name = "Monopoly", Price = 200 };


            Campaign campaign = new Campaign { Id = 1, Name = "Black Friday" };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            SaleManager saleManager = new SaleManager();
            saleManager.GameSale(game1, gamer1, campaign);
        }
    }
}
