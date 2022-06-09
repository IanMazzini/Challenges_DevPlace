using System;

namespace Dia_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            int opc;

            do
            {
                Console.WriteLine("Ingrese el numero del ejercicio: ");
                opc = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        obj.Ejercicio1();
                        break;

                    case 2:
                        obj.Ejercicio2();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("No existe un ejercicio con ese numero");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc > 2);
        }


        public void Ejercicio1()
        {
            int total = 3;
            Persona[] personas = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                personas[i] = new Persona();

                Console.WriteLine("Ingrese el nombre de la persona: ");
                personas[i].Nombre = Console.ReadLine();

            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }

        public void Ejercicio2()
        {

            Persona persona = new Persona();

            string nombre;
            int edad, dni;
            try
            {

                do
                {


                    Console.WriteLine("Ingrese el nombre de la persona");
                    nombre = Console.ReadLine();


                    Console.WriteLine("Ingrese la edad de la persona");
                    edad = Int32.Parse(Console.ReadLine());


                    Console.WriteLine("Ingrese el DNI de la persona");
                    dni = Int32.Parse(Console.ReadLine());
                }
                while (nombre != "" || edad > 0 || dni > 0);

                persona.Nombre = nombre;
                persona.edad = edad;
                persona.dni = dni;
            }
            catch
            {
                Console.WriteLine("No puede ser un valor nulo");
            }

            
        }


    }

    
}
