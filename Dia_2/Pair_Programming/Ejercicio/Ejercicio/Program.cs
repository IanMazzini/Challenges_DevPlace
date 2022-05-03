using System;
using System.Collections;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            cola();
        }

        static void cola()
        {

            double type, t_Type;
            Queue mycola = new Queue();
            int count = 0;
            try
            {
                for (byte i = 0; i < 5; i++)

                {
                    count++;
                    Console.Write($"Ingrese numero {count}: ");
                    type = Int32.Parse(Console.ReadLine());
                    mycola.Enqueue(type);
                    Console.Clear();
                }
                Console.Write($"La cola es: ");

                for (byte i = 0; i < 5; i++)

                {
                    t_Type = (double)mycola.Dequeue();
                    Console.Write(t_Type + "|");
                }

            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Ingresaste un numero incorrecto.");
            }

            Console.ReadKey();
        }
    }
}
