using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Character
    {
        public Character(string name, string classe, int nivel, string race)
        {
            Name = name;
            Classe = classe;
            Nivel = nivel;
            Race = race;
        }

        public string Name { get; set; }

        public string Classe { get; set; }

        public int Nivel { get; set; }

        public string Race { get; set; }

        
    }
}
