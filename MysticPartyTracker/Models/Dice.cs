using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Dice
    {
        public int Side {  get; set; }

        public Dice(int side)
        {
            Side = side;

        }

        public int Side()
        {
            //Retorna o valor de rolagem de dado.
            return new Random().Next(Side) + 1;
        }
    }
}
