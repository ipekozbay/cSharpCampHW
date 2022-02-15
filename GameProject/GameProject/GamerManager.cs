using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("gamer added");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("gamer updated ");
        }
    }
}
