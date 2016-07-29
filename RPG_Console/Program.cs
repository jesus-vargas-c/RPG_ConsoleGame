using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Enums;
using RPG_Console.Modelos.TipoArmas;
using RPG_Console.Modelos.TipoPersonajes;
using RPG_Console.Models;

namespace RPG_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Arma espada = new Espada("ha partido en dos al enemigo");
            Arma arco = new Arco("ha acertado en el corazón del enemigo");
            Arma hechizo = new Hechizo("ha convertido en mono al enemigo");
            Personaje Cohan = new Paladin("Cohan", espada);
            Personaje Legolas = new Elfo("Legolas", arco);
            Personaje Merlin = new Mago("Merlin",hechizo);
            Cohan.Atacar();
            Console.WriteLine("==================================");
            Legolas.Atacar();
            Console.WriteLine("==================================");
            Merlin.Atacar();
            Console.WriteLine("==================================");
            Cohan.Arma = arco;
            Cohan.Atacar();
            Console.WriteLine("==================================");
            Legolas.Arma = hechizo;
            Legolas.Atacar();
            Console.WriteLine("==================================");
            Merlin.Arma = espada;
            Merlin.Atacar();
            Console.WriteLine("==================================");
            Console.ReadLine();
        }
    }
}
