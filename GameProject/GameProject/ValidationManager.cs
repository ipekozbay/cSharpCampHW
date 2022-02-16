using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class ValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer == null)
            {
                Console.WriteLine("no gamer ");
            }
            return true;
        }
    }
}
