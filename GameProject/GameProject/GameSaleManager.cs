using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer,Game game, Campaign campaign)
        {
            Console.WriteLine("sale has been made : "+ gamer.Name+game.GameName+campaign.CampaignName);
        }
    }
}
