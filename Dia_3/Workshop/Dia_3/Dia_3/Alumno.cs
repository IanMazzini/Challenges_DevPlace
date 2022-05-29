using System;
using System.Collections.Generic;
using System.Text;

namespace Dia_3
{
    class Alumno
    {
        public int NroAl { get; set; }

        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        public bool buscarAlumno(int[] legArreglo, int leg)
        {

            foreach (int li in legArreglo)
            {
                if (li == leg)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
