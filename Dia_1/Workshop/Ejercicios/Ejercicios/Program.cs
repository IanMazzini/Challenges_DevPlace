using System;

namespace Ejercicios
{

    class Ejercicios
    {
        static void Main(string[] args)
        {
            Ejercicios obj = new Ejercicios();

            int opc;
         
            do {
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

                    case 4:
                        obj.Ejercicio4();
                        break;

                    case 6:
                        obj.Ejercicio6();
                        break;

                    case 7:
                        obj.Ejercicio7();
                        break;

                    case 8:
                        obj.Ejercicio8();
                        break;

                    case 9:
                        obj.Ejercicio9();
                        break;

                    case 10:
                        obj.Ejercicio11();
                        break;

                    case 13:
                        obj.Ejercicio13();
                        break;

                    case 14:
                        obj.Ejercicio14();
                        break;

                    case 15:
                        obj.Ejercicio15();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("No existe un ejercicio con ese numero");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc > 16);
        }

        public void Ejercicio1()
        {
            int num = 0;

            do
            {
                Console.WriteLine("Ingrese un numero positivo: ");
                num = Int32.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Debes ingresar un numero positivo");
                }
            } while (num < 0);

            int suma = 0;

            for (int i = num; i < num + 100; i++)
            {
                suma += i;
            }

            Console.WriteLine("La suma de los 100 numeros siguientes a " + num + " es: " + suma);
            Console.ReadKey();
        }

        public void Ejercicio2()
        {
            int primerNumero;
            int segundoNumero;

            do
            {
                Console.WriteLine("Introduzca un numero: ");
                primerNumero = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nIntroduzca un numero distinto al anterior: ");
                segundoNumero = Int32.Parse(Console.ReadLine());

                if (primerNumero == segundoNumero)
                {
                    Console.WriteLine("Los numeros introducidos no son validos, deben ser numeros distintos");
                }
            } while (primerNumero == segundoNumero);

            if (primerNumero > segundoNumero)
            {
                int mayor = primerNumero;
                primerNumero = segundoNumero;
                segundoNumero = mayor;
            }

            for (int i = primerNumero; i <= segundoNumero; i += 7)
            {
                Console.WriteLine( i + " " );
            }
        }

        public void Ejercicio3()
        {
            Console.WriteLine("Ingrese numeros, el programa se acabara cuando la suma de los numeros sea mayor a 150");

            int num;
            int suma = 0;
            int totalAcumulado = 0;

            do
            {
                num = Int32.Parse(Console.ReadLine());
                suma += num;
                totalAcumulado++;
            } while (suma <= 150);

            Console.WriteLine("Ingresaste un total de " + totalAcumulado + " numeros.");
            Console.WriteLine("La suma total de los numeros ingresados es: " + suma);
            Console.WriteLine("La media de los numeros ingresados es " + suma / totalAcumulado);
        }

        public void Ejercicio4()
        {
            string trabajador;
            int horasTrabajadas;
            int valorHora;
            int salario;

            Console.Write("Ingrese el nombre del trabajador: ");
            trabajador = Console.ReadLine();

            Console.Write("Ingrese cuantas horas trabajo " + trabajador + " este mes: ");
            horasTrabajadas = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese que valor tiene cada hora de trabajo: ");
            valorHora = Int32.Parse(Console.ReadLine());

            salario = horasTrabajadas * valorHora;
            Console.Write("El sueldo de " + trabajador + " este mes, sera de: " + salario);
        }

        public void Ejercicio6()
        {
            double hora, contPromocion, precioPromocion, pago;
            double precio = 1.5;

            Console.WriteLine("Escribe el numero de horas consumidas: ");
            hora = Int32.Parse(Console.ReadLine());

            contPromocion = hora / 5;
            precioPromocion = contPromocion * 1.5;
            pago = hora * precio - precioPromocion;
            Console.WriteLine("Debe pagar $" + pago + " por " + hora + " horas de internet");
            Console.WriteLine("Horas de promocion: " + contPromocion);
        }

        public void Ejercicio7()
        {
            int segundos;
            int minutos;
            int horas;

            Console.WriteLine("Ingrese una cantidad de segundos: ");
            segundos = Int32.Parse(Console.ReadLine());

            minutos = segundos / 60;
            horas = segundos / 3600;

            Console.WriteLine("Horas: " + horas);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos: " + segundos);
        }

        public void Ejercicio8()
        {
            double salarioActual;
            double salarioIncrementado;
            double salarioFinal;

            Console.WriteLine("Ingrese el salario actual del empleado: ");
            salarioActual = Int32.Parse(Console.ReadLine());

            salarioIncrementado = salarioActual * 8 / 100 + salarioActual;
            salarioFinal = salarioIncrementado - (salarioIncrementado * 2.5 / 100);

            Console.WriteLine("Con el incremento tu salario es: " + salarioIncrementado);
            Console.WriteLine("Tu salario quitando el 2.5% por servicios es: " + salarioFinal);
        }

        public void Ejercicio9()
        {
            float b;
            float B;
            float h;
            float area;

            Console.WriteLine("Ingrese la longitud de b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese la longitud de B: ");
            B = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese la longitud de h: ");
            h = Int32.Parse(Console.ReadLine());

            Console.Clear();

            area = (b + B) * h / 2;

            Console.WriteLine("El area del trapecio es: " + area);
        }

        public void Ejercicio11()
        {
            int alturaIntroducida;

            Console.WriteLine("Introduzca la altura de la piramide");

            alturaIntroducida = Int32.Parse(Console.ReadLine());

            int altura = 1;
            int i = 0;
            int espacios = alturaIntroducida - 1; 

            while (altura <= alturaIntroducida)
            {

                // Insertar espacios
                for (i = 1; i <= espacios; i++)
                {
                    Console.Write(" ");
                }

                // Hace las lineas
                for (i = 1; i < altura; i++)
                {
                    Console.Write(i);
                }

                // Invierte la lineas
                for (i = altura; i > 0; i--)
                {
                    Console.Write(i);
                }

                Console.WriteLine("");

                altura++;
                espacios--;
            }
 
        }

        public void Ejercicio13()
        {
            double salario, salarioTotal, incremento, nuevoSalario;

            Console.WriteLine("Escriba su salario actual");
            salario = Int32.Parse(Console.ReadLine());

            incremento = salario * 0.25;
            nuevoSalario = salario + incremento;
            salarioTotal = nuevoSalario * 10;

            Console.WriteLine("Tu nuevo salario con un incremento del 25% es $" + nuevoSalario + ".");
            Console.WriteLine("Tu salario total por haber trabajado 10 meses es de $" + salarioTotal + ".");
        }

        public void Ejercicio14()
        {
            int numero_de_aprobados, numero_de_desaprobados, numero_de_notables, numero_de_sobresalientes;
            double porcentaje_superados, porcentaje_desaprobados, porcentaje_aprobados, porcentaje_notables, porcentaje_sobresalientes;
            int total;
            Console.WriteLine("Ingresa el valor de numero de aprobados:");
            numero_de_aprobados = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de numero de desaprobados:");
            numero_de_desaprobados = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de numero de notables:");
            numero_de_notables = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de numero de sobresalientes:");
            numero_de_sobresalientes = Int32.Parse(Console.ReadLine());

            total = numero_de_desaprobados + numero_de_aprobados + numero_de_notables + numero_de_sobresalientes;

            porcentaje_superados = 100 * (numero_de_aprobados + numero_de_notables + numero_de_sobresalientes) / total;
            porcentaje_desaprobados = 100 * numero_de_desaprobados / total;
            porcentaje_aprobados = 100 * numero_de_aprobados / total;
            porcentaje_notables = 100 * numero_de_notables / total;
            porcentaje_sobresalientes = 100 * numero_de_sobresalientes / total;

            Console.WriteLine("Valor de porcentaje aprobados: " + porcentaje_aprobados);
            Console.WriteLine("Valor de porcentaje desaprobados: " + porcentaje_desaprobados);
            Console.WriteLine("Valor de porcentaje notables: " + porcentaje_notables);
            Console.WriteLine("Valor de porcentaje sobresalientes: " + porcentaje_sobresalientes);
            Console.WriteLine("Valor de total: " + total);
        }

        public void Ejercicio15()
        {
            double costo_total, costo_comprador, ganancia, impuestos;

            Console.WriteLine("Ingrese el costo total del Vehiculo:");
            costo_total = Int32.Parse(Console.ReadLine());

            ganancia = costo_total * 0.12;
            impuestos = costo_total * 0.06;

            costo_comprador = costo_total + ganancia + impuestos;

            Console.WriteLine("El costo para el vendedor: $" + costo_total);
            Console.WriteLine("El costo para el comprador: $" + costo_comprador);
        }
    }
}
