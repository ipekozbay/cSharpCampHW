using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            Gamer gamer2 = new Gamer();
            Gamer gamer3 = new Gamer();

            GamerManager gamerManager1 = new GamerManager();    

            gamer1.Name = "ipek";
            gamer1.LastName = "ozbay";
            gamer1.Id = 1;

            gamerManager1.Add(gamer1);
            gamerManager1.Delete(gamer2);
            gamerManager1.Update(gamer3);

            Game game1 = new Game();
            game1.GameName = "cs";


            Campaign campaign1 = new Campaign();    
            Campaign campaign2 = new Campaign();

            campaign1.CampaignName = "student campaign";
            campaign2.CampaignName = "gamer campaign";

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.AddCampaign(campaign1);
            campaignManager1.DeleteCampaign(campaign2);

            GameSaleManager gameSaleManager1 = new GameSaleManager();
            gameSaleManager1.Sale(gamer1,game1,campaign2);
        }
    }
}
