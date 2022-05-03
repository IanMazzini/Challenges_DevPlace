using System;

namespace Ejercicio_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Escriba un numero");
                if (Int32.TryParse(Console.ReadLine(), out array[i]))
                {
                    suma += array[i];
                }
                else{
                    Console.WriteLine("El valor ingresado no es un numero");
                }
                
            }
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El promedio es: " + (double) suma / array.Length);
        }
    }
}
