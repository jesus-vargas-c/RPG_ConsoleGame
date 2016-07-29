using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Modelos.TipoArmas;
using RPG_Console.Models;
using RPG_Console.Enums;

namespace RPG_Console.Modelos.TipoPersonajes
{
    public class Mago : Personaje
    {
        public Mago(string nombre, Arma arma):base()
        {
            Arma = arma ?? new Hechizo("ha acertado en el corazón del enemigo");
            Nombre = nombre;
        }

        public override void Atacar()
        {
            Console.WriteLine(string.Format("{0} {1}", Nombre, Arma.Usar()));
        }
    }
}
