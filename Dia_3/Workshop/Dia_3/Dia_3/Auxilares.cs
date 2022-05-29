using System;
using System.Collections.Generic;
using System.Text;

namespace Dia_3
{
    class Auxiliares
    {
        public int randomNum(int min, int max)
        {
            Random rand = new Random();

            return rand.Next(min, max);
        }

        public void eliminarNum(int n, List<int> L)
        {
            L.Remove(n);

            foreach (int a in L)
            {
                Console.WriteLine(a);
            }

        }

        public void reemplazar(Stack<int> pila, int nuevo, int viejo)
        {
            int length = pila.ToArray().Length;
            
            for (int i = 0; i < length; i++)
            {
                if (nuevo == pila.ToArray()[i])
                {
                    pila.ToArray()[i] = viejo;
                }
            }

            foreach (int mostrar in pila)   
            {
                Console.WriteLine(mostrar);
            }
        }

    }
}
