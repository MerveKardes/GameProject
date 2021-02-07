using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager:ISaleService
    {
        public void GameSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.Name + " isimli oyunu " + gamer.FirstName + " isimli kullanıcı " + campaign.Name + " kampanyası ile satın aldı");
        }
    }
}
