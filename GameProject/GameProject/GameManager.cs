using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameManager : IGamerService
    {
        public void Add()
        {
            Console.WriteLine("game added");        }

        public void Delete()
        {
            Console.WriteLine("game deleted");        }

        public void Update()
        {
            Console.WriteLine("game updated");        }
    }
}
