using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bienvenido, debes introducir el ejercicio que quieres realizar:"); 
                int ejercicio = Int32.Parse(Console.ReadLine());
                //Console.WriteLine("Has elegido el ejercicio: " + ejercicio);
                switch (ejercicio)
                {
                    case 2:
                        Program.Ejercicio2();
                        break;
                    case 3:
                        Program.Ejercicio3();
                        break;
                    case 4:
                        Program.Ejercicio4();
                        break;
                    case 7:
                        Program.Ejercicio7();
                        break;
                    case 8:
                        Program.Ejercicio8();
                        break;
                    case 9:
                        Program.Ejercicio9();
                        break;
                    case 10:
                        Program.Ejercicio10();
                        break;
                    case 11:
                        Program.Ejercicio11();
                        break;
                    case 12:
                        Program.Ejercicio12();
                        break;
                    default:
                        Console.WriteLine("No existe el ejercicio " + ejercicio + ".");
                        break;
                }
                Console.ReadLine();
            }
            catch
            {
            }
        }

        static void Ejercicio2()
        {
            try
            {
                Console.WriteLine("introduce un número:");
                int numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("introduce otro número:");
                int numero2 = Int32.Parse(Console.ReadLine());
                if (numero1 > numero2)
                {
                    Console.WriteLine("El numero menor es: " + numero2 + " el segundo número que has puesto.");
                }
                else if (numero1 < numero2)
                {
                    Console.WriteLine("El numero menor es: " + numero1 + " el primer número que has puesto.");
                }
                else
                {
                    Console.WriteLine("No hay un número menor que el otro.");
                }
            }
            catch
            {
            }
        }
        static void Ejercicio3()
        {
            try
            {
                List<int> list = new List<int>();
                Console.WriteLine("introduce el primer número:");
                list.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("introduce el segundo número:");
                list.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("introduce el tercer número:");
                list.Add(Int32.Parse(Console.ReadLine()));
                int n = 3;
                for (int j = 0; j < n - 1; j++)
                {
                    if (list[j] < list[j + 1]) //aquí se decide el orden de la lísta
                    {
                        int aux = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = aux;
                    }
                }
                System.Console.WriteLine("El número mayor es: " + list[0]);
            }
            catch
            {
            }
        }
        static void Ejercicio4()
        {
            try
            { 
                List<int> list = new List<int>();
                Console.WriteLine("introduce el primer número:");
                list.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("introduce el segundo número:");
                list.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("introduce el tercer número:");
                list.Add(Int32.Parse(Console.ReadLine()));
                int n = 3;
                for (int j = 0; j < n - 1; j++)
                {
                    if (list[j] < list[j + 1]) //aquí se decide el orden de la lísta
                    {  
                       int aux = list[j]; 
                        list[j] = list[j + 1]; 
                        list[j + 1] = aux;
                    }
                 }
                foreach (int prime in list)
                {
                    System.Console.WriteLine(prime);
                }
            }
            catch
            {
            }
        }
        static void Ejercicio7()
        {
            try
            {
                Console.WriteLine("Introduce una nota:");
                int nota = Int32.Parse(Console.ReadLine());
                if (nota < 5)
                {
                    Console.WriteLine("SUSPENSO.");
                }
                else if (nota < 7)
                {
                    Console.WriteLine("APROBADO.");
                }

            }
            catch
            {
            }
        }
        static void Ejercicio8()
        {
        }
        static void Ejercicio9()
        {
        }
        static void Ejercicio10()
        {
        }
        static void Ejercicio11()
        {
        }
        static void Ejercicio12()
        {
        }
    }
}
