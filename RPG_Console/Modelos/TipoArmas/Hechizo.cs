using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Models;

namespace RPG_Console.Modelos.TipoArmas
{
    public class Hechizo : Arma
    {
        public Hechizo(string accion)
        {
            Accion = !string.IsNullOrEmpty(accion) ? accion : "No causa efecto";
        }

        public override string Usar()
        {
            return Accion;
        }
    }
}
