using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("new campaign added");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("campaign deleted");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("campaign updated");
        }
    }
}
