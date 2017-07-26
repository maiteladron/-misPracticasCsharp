using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        public static object System { get; private set; }

        static void Main(string[] args)
        {
            try
            {
                int ejercicio = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido, debes introducir el ejercicio que quieres realizar: (0 escape)");
                    ejercicio = Int32.Parse(Console.ReadLine());
                    switch (ejercicio)
                    {
                        case 0:
                            Console.WriteLine("Adios.");
                            break;
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
                        case 13:
                            Program.Ejercicio13();
                            break;
                        case 14:
                            Program.Ejercicio14();
                            break;
                        case 15:
                            Program.Ejercicio15();
                            break;
                        case 16:
                            Program.Ejercicio16();
                            break;
                        case 17:
                            Program.Ejercicio17();
                            break;
                        case 18:
                            Program.Ejercicio18();
                            break;
                        case 19:
                            Program.Ejercicio19();
                            break;
                        case 20:
                            Program.Ejercicio20();
                            break;
                        case 21:
                            Program.Ejercicio21();
                            break;
                        case 22:
                            Program.Ejercicio22();
                            break;
                        case 23:
                            Program.Ejercicio23();
                            break;
                        case 24:
                            Program.Ejercicio24();
                            break;
                        case 25:
                            Program.Ejercicio25();
                            break;
                        case 26:
                            Program.Ejercicio26();
                            break;
                        case 27:
                            Program.Ejercicio27();
                            break;
                        case 28:
                            Program.Ejercicio28();
                            break;
                        case 29:
                            Program.Ejercicio29();
                            break;
                        case 30:
                            Program.Ejercicio30();
                            break;
                        case 31:
                            Program.Ejercicio31();
                            break;
                        case 32:
                            Program.Ejercicio32();
                            break;
                        default:
                            Program.Ejercicio(ejercicio);
                            break;
                    }
                    Console.ReadLine();
                } while (ejercicio != 0);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio(int ejercicio)
        {
            try
            {
                Console.WriteLine("No existe el ejercicio " + ejercicio + ".");
            }
            catch
            {
                Console.WriteLine("ERROR");
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
                Console.WriteLine("ERROR");
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
                int count = 0;
                do
                {
                    count = 0;
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (list[j] < list[j + 1]) //aquí se decide el orden de la lísta
                        {
                            int aux = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = aux;
                            count++;
                        }
                    }
                } while (count != 0);
                Console.WriteLine("El número mayor es: " + list[0]);
            }
            catch
            {
                Console.WriteLine("ERROR");
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
                int count = 0;
                do
                {
                    count = 0;
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (list[j] < list[j + 1]) //aquí se decide el orden de la lísta
                        {
                            int aux = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = aux;
                            count++;
                        }
                    }
                } while (count != 0);
                foreach (int prime in list)
                {
                    global::System.Console.WriteLine(prime);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
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
                else if (nota < 9)
                {
                    Console.WriteLine("NOTABLE.");
                }
                else if (nota < 10)
                {
                    Console.WriteLine("SOBRESALIENTE.");
                }
                else if (nota == 10)
                {
                    Console.WriteLine("MATRÍCULA.");
                }
                else
                {
                    Console.WriteLine("NO TENEMOS CALIFICACIÓN.");
                }

            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio8()
        {
            try
            {
                Console.WriteLine("introduce un número:");
                float numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("introduce otro número:");
                float numero2 = float.Parse(Console.ReadLine());
                if (numero1 % numero2 == 0)
                {
                    Console.WriteLine("El número " + numero1 + " es múltiplo de " + numero2);
                }
                else if (numero2 % numero1 == 0)
                {
                    Console.WriteLine("El número " + numero2 + " es múltiplo de " + numero1);
                }
                else
                {
                    Console.WriteLine("No son múltiplos.");
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio9()
        {
            try
            {
                Console.WriteLine("Introduce un día (dd):");
                int dia = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un mes (mm):");
                int mes = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un año (aaaa):");
                int ano = Int32.Parse(Console.ReadLine());
                DateTime fecha = DateTime.Parse(dia + "/" + mes + "/" + ano);
                Console.WriteLine("Fecha correcta");
            }
            catch
            {
                Console.WriteLine("Fecha incorrecta.");
            }
        }
        static void Ejercicio10()
        {
            try
            {
                Console.WriteLine("Introduce un día:");
                int dia = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un mes:");
                int mes = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un año:");
                float ano = float.Parse(Console.ReadLine());
                bool bisiesto;
                if (ano % 400 == 0)
                {
                    bisiesto = true;
                }
                else if ((ano % 100 != 0) && (ano % 4 == 0))
                {
                    bisiesto = true;
                }
                else
                {
                    bisiesto = false;
                }
                switch (mes)
                {
                    case 1:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 2:
                        if (dia <= 28)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else if ((dia == 29) && bisiesto)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 3:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 4:
                        if (dia <= 30)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 5:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 6:
                        if (dia <= 30)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 7:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 8:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 9:
                        if (dia <= 30)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 10:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 11:
                        if (dia <= 30)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    case 12:
                        if (dia <= 31)
                        {
                            Console.WriteLine("Fecha correcta.");
                        }
                        else
                        {
                            Console.WriteLine("Fecha incorrecta.");
                        }
                        break;
                    default:
                        Console.WriteLine("Fecha incorrecta.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio11()
        {
            try
            {
                Console.WriteLine("introduce un número:");
                int v1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("introduce otro número:");
                int v2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("introduce otro número:");
                int v3 = Int32.Parse(Console.ReadLine());
                if (v1 == 0 && v2 == 0 && v3 == 0) Console.WriteLine("Todas las variables son 0.");
                if (v1 > 0 && v2 > 0 && v3 > 0)
                {
                    Console.WriteLine("Todas las variables son positivas.");
                    Console.WriteLine("Todas las variables tienen el mismo signo.");
                }
                if (v1 < 0 && v2 < 0 && v3 < 0) Console.WriteLine("Todas las variables tienen el mismo signo.");
                int i = 0;
                if (Math.Abs(v1) == Math.Abs(v2)) i++;
                if (Math.Abs(v3) == Math.Abs(v2)) i++;
                if (Math.Abs(v1) == Math.Abs(v3)) i++;
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Todos sus valores son distintos.");
                        if (Math.Abs(v1) < Math.Abs(v2) && Math.Abs(v2) < Math.Abs(v3)) Console.WriteLine("TEl valor de v2 esta comprendido entre los de v1 y v3.");
                        if (Math.Abs(v3) < Math.Abs(v2) && Math.Abs(v2) < Math.Abs(v1)) Console.WriteLine("TEl valor de v2 esta comprendido entre los de v1 y v3.");
                        break;
                    case 1:
                        Console.WriteLine("Dos de sus valores coinciden.");
                        Console.WriteLine("Como máximo dos de sus valores coinciden.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio12()
        {
            try
            {
                Console.WriteLine("Introduce un mes (mm):");
                int mes = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un año (aaaa):");
                int ano = Int32.Parse(Console.ReadLine());
                Console.WriteLine(global::System.DateTime.DaysInMonth(ano, mes));
            }
            catch
            {
                Console.WriteLine("Fecha incorrecta.");
            }
        }
        static void Ejercicio13()
        {
            try
            {
                Console.WriteLine("Introduce un numero:");
                int num = Int32.Parse(Console.ReadLine());
                int cont = 0;
                for (int j = 1; j <= num; j++)//aquí comprobamos si el número es primo o no
                {
                    if (num % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                { //si variable cont es mayor a dos, el numero es divisible en mas de dos numero osea no es primo
                    Console.WriteLine("El número " + num + " es primo.");
                }
                else
                {
                    Console.WriteLine("El número " + num + " NO es primo.");
                }
            }
            catch
            {
                Console.WriteLine("ERROR.");
            }
        }
        static void Ejercicio14()
        {
            try
            {
                int cont = 0; //un contador, el cual si es mayor a dos indica que el numero no es primo
                int num = 2;
                for (int i = 0; i < 50; num++)
                {
                    cont = 0;//igualamos a cero para hacer otra evaluacion con otro numero
                    for (int j = 1; j <= num; j++)//aquí comprobamos si el número es primo o no
                    {
                        if (num % j == 0)
                        {
                            cont = cont + 1;
                        }
                    }
                    if (cont <= 2)
                    { //si variable cont es mayor a dos, el numero es divisible en mas de dos numero osea no es primo
                        Console.WriteLine(num);
                        i++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio15()
        {
            try
            {
                Console.WriteLine("introduce un dividendo:");
                int dividendo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("introduce un divisor:");
                int divisor = Int32.Parse(Console.ReadLine());
                int cociente = 1;
                for (int i = 1; (dividendo >= divisor * i); i++)
                {
                    cociente = i;
                }
                int resto = (dividendo - (divisor * cociente));
                Console.WriteLine("Cociente: " + cociente);
                Console.WriteLine("Resto: " + resto);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio16()
        {
            try
            {
                Console.WriteLine("introduce una serie de números, si introduces el 0 calcula la suma y la media.");
                float med = 0;
                int sum = 0;
                int i = 0;
                do
                {
                    i = Int32.Parse(Console.ReadLine());
                    sum = sum + i;
                    med++;
                }
                while (i != 0);
                med = sum / (med - 1);
                Console.WriteLine(sum);
                Console.WriteLine(med);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio17()
        {
            try
            {
                List<int> list = new List<int>();
                int n = 50;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("introduce el número " + i + ":");
                    list.Add(Int32.Parse(Console.ReadLine()));
                }
                int count = 0;
                do
                {
                    count = 0;
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (list[j] < list[j + 1]) //aquí se decide el orden de la lísta
                        {
                            int aux = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = aux;
                            count++;
                        }
                    }
                } while (count != 0);

                global::System.Console.WriteLine("El número mayor es: " + list[0]);
                global::System.Console.WriteLine("El número menor es: " + list[n - 1]);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio18()
        {
            try
            {
                List<int> list = new List<int>();
                int n = 50;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("introduce el número " + i + ":");
                    list.Add(Int32.Parse(Console.ReadLine()));
                }
                int count = 0;
                int sum = 0;
                do
                {
                    count = 0;
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (list[j] < list[j + 1]) //aquí se decide el orden de la lísta
                        {
                            int aux = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = aux;
                            count++;
                        }
                    }
                } while (count != 0);
                foreach (int num in list)
                {
                    sum = sum + num;
                }
                global::System.Console.WriteLine("El número mayor es: " + list[0]);
                global::System.Console.WriteLine("El número menor es: " + list[n - 1]);
                global::System.Console.WriteLine("La media es: " + (sum / n));
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio19()
        {
            try
            {
                Console.WriteLine("introduce un número:");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine(num * (num + 1) / 2);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio20()
        {
            try
            {
                List<int> list = new List<int>();
                list.Add(0);
                list.Add(1);
                int count = 0;
                int n = 2;
                for (n = 2; count <= 1000; n++)
                {
                    count = ((3 * list[n - 1]) + (2 * list[n - 2]));
                    list.Add(count);
                }
                Console.WriteLine("Valor del primer termino mayor o igual a 1000: " + count);
                Console.WriteLine("Valor del rango: " + n);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio21()
        {
            try
            {
                Console.WriteLine("introduce un número de no más de 6 cifras:");
                int num = Int32.Parse(Console.ReadLine());
                string numero = num.ToString();
                string aux = "";
                Boolean bol = false;
                for (int i = 0; i < numero.Length; i++)
                {
                    aux = numero.Substring(i, 1) + aux;
                }
                if (aux == numero)
                {
                    bol = true;
                }
                Console.WriteLine("El número es capicúa: " + bol);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio22()
        {
            try
            {
                Console.WriteLine("introduce un número de no más de 6 cifras:");
                long num = Int64.Parse(Console.ReadLine());
                string numero = num.ToString();
                string aux = "";
                Boolean bol = false;
                for (int i = 0; i < numero.Length; i++)
                {
                    aux = numero.Substring(i, 1) + aux;
                }
                if (aux == numero)
                {
                    bol = true;
                }
                Console.WriteLine("El número es capicúa: " + bol);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio23()
        {
            try
            {
                string secuencia1 = "";
                string secuencia2 = "";
                int contador = 1;
                int muertos = 0;
                int heridos = 0;
                bool acierto = false;
                //JUGADOR 1
                Console.WriteLine("El primer jugador introduce 4 números. El segundo jugador tiene 8 intentos para adivinar los números y el orden.");
                do
                {
                    Console.WriteLine("Jugador 1:");
                    Console.WriteLine("Introduce la secuencia de cuatro números:");
                    int secuencia = Int32.Parse(Console.ReadLine());
                    secuencia1 = secuencia.ToString();
                } while (secuencia1.Length != 4);
                Console.Clear();
                //JUGADOR 2
                Console.WriteLine("El primer jugador introduce 4 números. El segundo jugador tiene 8 intentos para adivinar los números y el orden.");
                do
                {
                    do
                    {
                        Console.WriteLine("Jugador 2:");
                        Console.WriteLine("Intento: " + contador + ". Introduce la secuencia de cuatro números:");
                        int secuencia = Int32.Parse(Console.ReadLine());
                        secuencia2 = secuencia.ToString();
                    } while (secuencia2.Length != 4);
                    muertos = 0;
                    heridos = 0;
                    for (int i = 0; i < secuencia1.Length; i++)
                    {
                        if (secuencia1.Substring(i, 1) == secuencia2.Substring(i, 1))
                        {
                            muertos++;
                        }
                        else
                        {
                            for (int j = 0; j < secuencia2.Length; j++)
                            {
                                if (secuencia1.Substring(i, 1) == secuencia2.Substring(j, 1))
                                {
                                    heridos++;
                                    j = secuencia2.Length;
                                }
                            }
                        }
                    }
                    if (muertos == 4) acierto = true;
                    contador++;
                    Console.WriteLine("Número de muertos: " + muertos + ", número de heridos: " + heridos);
                } while ((contador <= 8) && (acierto == false));
                Console.WriteLine(acierto);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio24()
        {
            try
            {
                Console.WriteLine("introduce un número (n):");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("introduce otro número (m):");
                int m = Int32.Parse(Console.ReadLine());
                int l = n - m;
                int resultado = Program.combinatorio(n) / (Program.combinatorio(m) * Program.combinatorio(l));
                Console.WriteLine(resultado);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static int combinatorio(int n)
        {
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                num = num * i;
            }
            return num;
        }
        static void Ejercicio25()
        {
            try
            {
                Console.WriteLine("introduce un número:");
                int n = Int32.Parse(Console.ReadLine());
                int[,] triangulo = new int[n + 1, n + 1];
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0)
                        {
                            triangulo[i, j] = 1;
                        }
                        else if (j == i)
                        {
                            triangulo[i, j] = 1;
                        }
                        else
                        {
                            int num1 = i - 1;
                            int num2 = j - 1;
                            int n1 = triangulo[num1, num2];
                            int n2 = triangulo[num1, j];
                            int n3 = n1 + n2;
                            triangulo[i, j] = n3;
                        }
                    }
                }
                for (int i = 0; i <= n; i++)
                {
                    string cadena = "";
                    for (int j = 0; j <= i; j++)
                    {
                        cadena = cadena + "(" + i + "," + j + ") = " + triangulo[i, j] + "   ";
                    }
                    Console.WriteLine(cadena);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio26()
        {
            try
            {
                int n = 0, millar = 0, resto = 0, centenas = 0, decenas = 0, unidades = 0;
                string romano = "";
                do
                {
                    Console.WriteLine("introduce un número (no superior a 3999): ");
                    n = Int32.Parse(Console.ReadLine());
                } while (n > 3999);
                millar = n / 1000;
                resto = n % 1000;
                centenas = resto / 100;
                resto = resto % 100;
                decenas = resto / 10;
                resto = resto % 10;
                unidades = resto;
                switch (millar)
                {
                    case 1: romano = romano + "M"; break;
                    case 2: romano = romano + "MM"; break;
                    case 3: romano = romano + "MMM"; break;
                }
                switch (centenas)
                {
                    case 1: romano = romano + "C"; break;
                    case 2: romano = romano + "CC"; break;
                    case 3: romano = romano + "CCC"; break;
                    case 4: romano = romano + "CD"; break;
                    case 5: romano = romano + "D"; break;
                    case 6: romano = romano + "DC"; break;
                    case 7: romano = romano + "DCC"; break;
                    case 8: romano = romano + "DCCC"; break;
                    case 9: romano = romano + "CM"; break;
                }
                switch (decenas)
                {
                    case 1: romano = romano + "X"; break;
                    case 2: romano = romano + "XX"; break;
                    case 3: romano = romano + "XXX"; break;
                    case 4: romano = romano + "XL"; break;
                    case 5: romano = romano + "L"; break;
                    case 6: romano = romano + "LX"; break;
                    case 7: romano = romano + "LXX"; break;
                    case 8: romano = romano + "LXXX"; break;
                    case 9: romano = romano + "XC"; break;
                }
                switch (unidades)
                {
                    case 1: romano = romano + "I"; break;
                    case 2: romano = romano + "II"; break;
                    case 3: romano = romano + "III"; break;
                    case 4: romano = romano + "IV"; break;
                    case 5: romano = romano + "V"; break;
                    case 6: romano = romano + "VI"; break;
                    case 7: romano = romano + "VII"; break;
                    case 8: romano = romano + "VIII"; break;
                    case 9: romano = romano + "IX"; break;
                }
                Console.WriteLine(romano);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio27()
        {
            try
            {
                Console.WriteLine("introduce un número:");
                int num = Int32.Parse(Console.ReadLine());
                int cont = 0;
                for (int j = 1; j < num; j++)//aquí comprobamos si el número es primo o no
                {
                    if (num % j == 0)
                    {
                        cont = cont + j;
                    }
                }
                if (cont == num)
                {
                    Console.WriteLine("El número " + num + " es perfecto.");
                }
                else
                {
                    Console.WriteLine("El número " + num + " NO es perfecto.");
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio28()
        {
            try
            {
                int num = 1;
                int cont = 0;
                for (num = 1; num <= 10000; num++)
                {
                    cont = 0;
                    for (int j = 1; j < num; j++)//aquí comprobamos si el número es primo o no
                    {
                        if (num % j == 0)
                        {
                            cont = cont + j;
                        }
                    }
                    if (cont == num) Console.WriteLine(num);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio29()
        {
            try
            {
                int cont = 0;
                int num = 2;
                for (int i = 0; i < 4; num++)
                {
                    cont = 0;//igualamos a cero para hacer otra evaluacion con otro numero
                    for (int j = 1; j < num; j++)//aquí comprobamos si el número es primo o no
                    {
                        if (num % j == 0)
                        {
                            cont = cont + j;
                        }
                    }
                    if (cont == num)
                    {
                        Console.WriteLine(num);
                        i++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        static void Ejercicio30()
        {
            try
            {
                // declaramos las variables
                int num = 0; //con esta variable recorre los números para encontrar el pefecto
                int cont = 0; // con esta variable se calcula si es perfecto.
                bool continuar = true; // detecta si hay que continuar o no
                bool sino = false; // detecta si la variable op es "sí" o "no"
                do//do para continuar
                {
                    num++; //aumentamos el número para no crear un bucle infinito
                    cont = 0;//iniciamos cont, para que no guarde las sumas de números anteriores
                    for (int j = 1; j < num; j++)//aquí comprobamos si el número es primo o no, nos vale para perfectos con modificaciones. Nunca se suma por el mismo número
                    {
                        if (num % j == 0)//quiere decir que es divisible
                        {
                            cont = cont + j;//ampliamos cont, para ver si llega a ser perfecto
                        }
                    }
                    if (cont == num)// si es Perfecto
                    {
                        Console.WriteLine(num + " es un número perfecto.");//mensaje por consola
                        do//do para sino
                        {
                            Console.WriteLine("¿Quieres el siguiente número perfecto (sí/no)?");//mensaje por consola
                            string op = Console.ReadLine();//cogemos contenido para la variable op
                            if (op == "sí")
                            {
                                //opción válida de op, por lo que quiere continuar con el siguiente número perfecto y sale del bucle sino
                                continuar = true;
                                sino = true;
                            }
                            else if (op == "no")
                            {
                                //opción válida de op, por lo que quiere no continuar con el siguiente número perfecto y sale del bucle sino
                                continuar = false;
                                sino = true;
                            }
                            else
                            {
                                //opción no válida de op, por lo que continua el bucle sino
                                sino = false;
                            }
                        } while (!sino);//si las opciones de op son correctas o no, si no lo son las vuelve a solicitar, si son correctas sale
                    }
                } while (continuar);//si quiere continuar o no
            }
            catch//si hay algún error viene aquí
            {
                Console.WriteLine("ERROR");//mensaje por consola
            }
        }
        static void Ejercicio31()//No realizo una funión externa ya que no me convencía el código que debía tener
        {
            try
            {
                //Tabla ASCII
                Console.WriteLine("TABLA ASCII COMPLETA:");//mensaje por consola
                for (int i = 32; i <= 126; i++)//Valores solicitados
                {
                    Console.WriteLine("El caracter número " + i + " es '" + (char)i + "'");//(char) convierte el valor de ascii al char, mensaje por consola
                }
                //de minúsculas a mayúsculas
                Console.WriteLine("FUNCIÓN DE TRANSFORMACIÓN DE MINÚSCULAS A MAYÚSCULAS:");//mensaje por consola
                for (int i = 97; i <= 122; i++)//Valores de ascii minúsculas
                {
                    char var = (char)i;//convertimos a char
                    string v = var.ToString();//convertimos a string
                    Console.WriteLine("La mayúscula correspondiente a '" + var + "' es '" + v.ToUpper() + "'");//ToUpper convierte a mayúsculas, mensaje por consola
                }
                //de mayúsculas a minúsculas
                Console.WriteLine("FUNCIÓN DE TRANSFORMACIÓN DE MAYÚSCULAS A MINÚSCULAS:");//mensaje por consola
                for (int i = 65; i <= 90; i++)//Valores de ascii mayúsculas
                {
                    char var = (char)i;//convertimos a char
                    string v = var.ToString();//convertimos a string
                    Console.WriteLine("La minúscula correspondiente a '" + var + "' es '" + v.ToLower() + "'");//ToLower convierte a minúsculas, mensaje por consola
                }
                //números
                Console.WriteLine("FUNCIÓN DE TRANSFORMACIÓN DE NÚMEROS:");//mensaje por consola
                for (int i = 48; i <= 57; i++)//Valores de ascii de los números
                {
                    char var = (char)i;//convertimos a char
                    string v = var.ToString();//convertimos a string
                    int num = Int32.Parse(v);//convertimos a integer/número
                    Console.WriteLine("El número correspondiente a la letra '" + var + "' es '" + num + "'");//mensaje por consola
                }

            }
            catch//si hay algún error viene aquí
            {
                Console.WriteLine("ERROR");//mensaje por consola
            }
        }

        static void Ejercicio32()//no añado la hora ya que para la media, no hace falta
        {
            try
            {
                int n = 0;// inicializamos una variable usada en todo el programa
                float[,] medicion = new float[10,4];//inicializamos y damos dimensión a un array, la última posición es para la temperatura media
                int contador = 0;//contador para los días de frio
                for (n = 0; n < 10; n++)//for inicial para rellenar el array
                {
                    int d = n + 1;//variable para impresión por pantalla
                    for (int m = 0; m < 3; m++)//segundofor para rellenar el array
                    {
                        int e = m + 1;//variable para impresión por pantalla
                        Console.WriteLine("introduce la medicion " + e + " del día " + d + ":");//solicitamos que ponga la temperatura
                        medicion[n,m] = float.Parse(Console.ReadLine());//recogemos la temperatura
                        if (m == 2)//rellenamos el último hueco del array con la temperatura media de ese día
                        {
                            medicion[n, 3] = ((medicion[n, 0] + medicion[n, 1] + medicion[n, 2]) / 3);//calculamos la media
                        }//fin if
                    }//fin for 2
                }//fin for 1
                for (n = 0; n < 10; n++)//for para recorrer el array y sacar los días de frío
                {
                   if(medicion[n, 3] < 0)//comprobamos que la media sea inferior a 0
                    {
                        contador++;//ampliamos en 1 el contador de días de frio
                    }
                }
                Console.WriteLine("De las mediciones sacadas de los 10 días, " + contador + " días hizo menos de 0 grados.");//impresión por pantalla del resultado
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
