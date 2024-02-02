using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrructura_de_clases
{
    public  class ExAlumno : Miembros_de_la_comunidad
    {
        public int matricula {  get; set; }
        public int CreditosCursados { get; set; }
        public string  carrera {  get; set; } 

    }
}
