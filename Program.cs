using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrructura_de_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Maestro profesor = new Maestro();
            // llamando la funcion ensenar para maestro
            profesor.Ensenar();

            Estudiante estudiante = new Estudiante();
            // llamando la funcion estudiar para maestro
            estudiante.Estudiar();
        }
    }
}
