using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.functions
{
    class SuperStrings
    {
        //Acorta cadena de texto
        public string MutaCadena(string cadena)
        {
            cadena = cadena.Substring(0, 4);
            return cadena;
        }

        //Da la fecha y hora actual
        public DateTime RetornaFecha()
        {
            DateTime fecha = DateTime.Now;
            return fecha;
        }
    }
}
