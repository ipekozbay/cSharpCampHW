using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("new campaign added");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("campaign deleted");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("campaign updated");
        }
    }
}
