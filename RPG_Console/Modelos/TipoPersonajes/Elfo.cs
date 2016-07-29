using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Enums;
using RPG_Console.Modelos.TipoArmas;
using RPG_Console.Models;

namespace RPG_Console.Modelos.TipoPersonajes
{
    public class Elfo : Personaje
    {
        
        public Elfo(string nombre, Arma arma):base()
        {
            Arma = arma ?? new Arco("ha acertado en el corazón del enemigo"); 
            Nombre = nombre;
        }

        public override void Atacar()
        {
            Console.WriteLine(string.Format("{0} {1}",Nombre,Arma.Usar()));
        }
    }
}
