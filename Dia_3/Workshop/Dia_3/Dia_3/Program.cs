using System;
using System.Collections.Generic;
using System.Linq;

namespace Dia_3
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
                    case 3:
                        obj.Ejercicio3();
                        break;

                    case 5:
                        obj.Ejercicio5();
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
            List<Alumno> lAlumno = new List<Alumno>();

            Auxiliares randomNum = new Auxiliares();

            Alumno buscarAlumno = new Alumno();

            int[] legArreglo = new int[30];
            int i = 0;

            do
            {
                legArreglo[i] = randomNum.randomNum(0, 12001);
                Alumno alumno = new Alumno();
                alumno.NroAl = legArreglo[i];
                alumno.Nota1 = randomNum.randomNum(0, 11);
                alumno.Nota2 = randomNum.randomNum(0, 11);
                alumno.Nota3 = randomNum.randomNum(0, 11);
                alumno.Nota4 = randomNum.randomNum(0, 11);
                lAlumno.Add(alumno);

                Console.WriteLine(alumno.NroAl);
                i++;
            } while (i < 30);

            Array.Sort(legArreglo);

            Console.WriteLine("Ingrese el numero del alumno para ver su legajo: ");
            int leg = int.Parse(Console.ReadLine());

            if (buscarAlumno.buscarAlumno(legArreglo, leg))
            {
                Console.WriteLine("El alumno Nro " + leg + " está en la lista y sus nota son:");

                Alumno alu = (Alumno)lAlumno.Where(a => a.NroAl == leg).Single();

                Console.WriteLine(alu.Nota1);
                Console.WriteLine(alu.Nota2);
                Console.WriteLine(alu.Nota3);
                Console.WriteLine(alu.Nota4);
                Console.WriteLine("------------------------------------------");
            }

        }

        public void Ejercicio2()
        {

            int[] arr1 = new int[10];
            int[] arr2 = new int[13];
            int[] arr3;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Primer arreglo:");
                Console.WriteLine("Ingrese un numero: ");
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Segundo arreglo:");
                Console.WriteLine("Ingrese un numero: ");
                arr2[i] = Int32.Parse(Console.ReadLine());
            }

            arr3 = arr1.Concat(arr2).ToArray();

            Array.Sort(arr3);
            foreach (int li in arr3)
            {
                Console.WriteLine(li);

            }

        }

        public void Ejercicio3()
        {
            Auxiliares eliminarNum = new Auxiliares();
            List<int> L = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                L.Add(i);
            }

            foreach (int n in L)
            {
                Console.WriteLine(n);
            }

            
            Console.WriteLine("Ingrese numero a eliminar: ");
            int f = Int32.Parse(Console.ReadLine());
            eliminarNum.eliminarNum(f,L);

        }

        public void Ejercicio5()
        {
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            // Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");

            foreach (int li in myStack)
            {
                Console.WriteLine(li);
            }

            Console.WriteLine("");

            Console.WriteLine("Ingrese el numero a reemplazar:");
            int viejo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero nuevo:");
            int nuevo = Int32.Parse(Console.ReadLine());

            Auxiliares reemplazar = new Auxiliares();

            reemplazar.reemplazar(myStack, nuevo, viejo);
        }
    }

        
    
}

