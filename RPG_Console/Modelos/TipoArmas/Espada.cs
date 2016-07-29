using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Models;

namespace RPG_Console.Modelos.TipoArmas
{
   public class Espada : Arma
    {
       public Espada(string accion):base()
       {
           Accion = !string.IsNullOrEmpty(accion) ? accion : "No causa efecto el arma";
       }

       public override string Usar()
       {
           return Accion;
       }
    }
}
