using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicos_de_clase
{
    internal class Program
    {
        static void menu()
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        {
                            Ejercicio1();
                        }
                        break;
                    case 2:
                        {
                            Ejercicio2();
                        }
                        break;
                    case 3:
                        {
                            Ejercicio3();
                        }
                        break;
                    case 4
                        {
                            Ejercicio4()
                        }
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }

            } while (opcion != 4);

        }
        menu()
static void MostrarMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione la Opción que desea realizar");
            Console.WriteLine("\n");
            Console.WriteLine("----------- Menú -----------");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Salir");
            Console.WriteLine("-----------------------------");
        }
        MostrarMenu()

static int ObtenerOpcion()
        {
            Console.Write("Elige una opción: ");
            int opción;
            while (!int.TryParse(Console.ReadLine(), out opción))
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                Console.Write("Elige una opción: ");
            }
            return opción;
        }

        ObtenerOpcion()




        static void Ejercicio1()
        {
            int numeroMayor = 0;
            int numeroMenor = int.MaxValue;
            int numeroIngresado;

            do
            {
                Console.WriteLine("Ingrese un número positivo (0 para salir):  ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > 0)
                {
                    if (numeroIngresado > numeroMayor)
                    {
                        numeroMayor = numeroIngresado;
                    }

                    if (numeroIngresado < numeroMenor)
                    {
                        numeroMenor = numeroIngresado;
                    }
                }
            } while (numeroIngresado != 0);

            Console.WriteLine("El número mayor ingresado es: {0}", numeroMayor);
            Console.WriteLine("El número menor ingresado es: {0}", numeroMenor);
        }



        static void Ejercicio2()
        {
            Console.WriteLine(" \n ¡Adivina el número que estoy pensando!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Piensa en un número entero positivo.");
            Console.WriteLine("Presiona Enter cuando estés listo.");
            Console.ReadLine();

            Console.WriteLine("2. Multiplica el numero por \"2\".");
            Console.WriteLine("Presiona Enter cuando estés listo.");
            Console.ReadLine();

            Console.WriteLine("3. Suma \"8\" al numero.");
            Console.WriteLine("Presiona Enter cuando estés listo.");
            Console.ReadLine();

            Console.WriteLine("4. Multiplica el numero por \"5\".");
            Console.WriteLine("Presiona Enter cuando estés listo.");
            Console.ReadLine();

            Console.WriteLine("5. Dime el numero resultante.");
            string resultadoFinal = Console.ReadLine();

            int numeroAdivinado = int.Parse(resultadoFinal.Substring(0, resultadoFinal.Length - 1)) - 4;

            Console.WriteLine("¡Tu número es el {0}!", numeroAdivinado);


        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ingrese una frase: ");
            string frase = Console.ReadLine();

            int contadorPalabras = 1;
            for (int i = 0; i < frase.Length; i++)
            {
                if (char.IsWhiteSpace(frase[i]))
                {
                    contadorPalabras++;
                }
            }

            int contadorVocales = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                char letra = frase[i];
                if (esVocal(letra))
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine("Número de palabras: " + contadorPalabras);
            Console.WriteLine("Número de vocales: " + contadorVocales);
        }


        static void Ejercicio4
        {
            Console.WriteLine("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        string palabraInvertida = "";
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida += palabra[i];
        }

    bool esPalindromo = palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);

        if (esPalindromo)
        {
            Console.WriteLine("La palabra \"" + palabra + "\" es un palíndromo.");
        }
        else
{
    Console.WriteLine("La palabra \"" + palabra + "\" no es un palíndromo.");
}