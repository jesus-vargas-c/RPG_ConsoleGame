using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Models
{
    public abstract class Arma
    {
        public string Accion { get; set; }
        public abstract string Usar();
    }
}
