using System;
using System.Collections.Generic;
using System.Text;

namespace Dia_4
{
    class Persona
    {
        public string Nombre { get; set; }
        public int edad { get; set; }
        public int dni { get; set; }


        public override string ToString()
        {
            return "Hola! Mi nombre es " + Nombre;
        }
    }
}
