using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Models;
using RPG_Console.Enums;
using RPG_Console.Modelos.TipoArmas;

namespace RPG_Console.Modelos.TipoPersonajes
{
    public class Paladin : Personaje
    {
        public Paladin(string nombre, Arma arma):base()
        {
            Arma = arma ?? new Espada("ha acertado en el corazón del enemigo");
            Nombre = nombre;
        }

        public override void Atacar()
        {
            Console.WriteLine(string.Format("{0} {1}", Nombre, Arma.Usar()));
        }
    }
}
