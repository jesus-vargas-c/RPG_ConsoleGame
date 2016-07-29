using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Enums;

namespace RPG_Console.Models
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public CharacterType Tipo { get; set; }
        public Arma Arma { get; set; }
        public abstract void Atacar();
    
    }
}
