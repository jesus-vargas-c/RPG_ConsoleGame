using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Models;

namespace RPG_Console.Modelos.TipoArmas
{
    public class Arco : Arma
    {
        public Arco(string accion) : base()
        {
            Accion = !string.IsNullOrEmpty(accion) ? accion : "El arma no causa efecto";
        }

        public override string Usar()
        {
            return Accion;
        }
    }
}
