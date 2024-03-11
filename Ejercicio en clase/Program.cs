Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Victor Daniel Sosa Lopez\t 0905-23-8230");
Console.ResetColor();

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
            case 4:
                {
                    Ejercicio4();
                }
                break;
            case 5:
                Console.WriteLine("¡Hasta luego!");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                break;
        }

    } while (opcion != 5);

}

static void MostrarMenu()
{
    Console.WriteLine("\nSeleccione la Opción que desea realizar");
    Console.WriteLine("\n");
    Console.WriteLine("************* Menú *************\n");
    Console.WriteLine("1. Ejercicio 1 (Numero mayor y menor ingresado)");
    Console.WriteLine("2. Ejercicio 2 (Adivinar el numero)");
    Console.WriteLine("3. Ejercicio 3 (Contador de palabras)");
    Console.WriteLine("4. Ejercicio 4 (Palindromo o no)");
    Console.WriteLine("5. Salir");
    Console.WriteLine("\n********************************");
}


static int ObtenerOpcion()
{
    Console.Write("\nElige una opción: ");
    int opción;
    while (!int.TryParse(Console.ReadLine(), out opción))
    {
        Console.WriteLine("Por favor, introduce un número válido.");
        Console.Write("Elige una opción: ");
    }
    return opción;
}





static void Ejercicio1()
{
    int numeroMayor = 0;
    int numeroMenor = int.MaxValue;
    int numeroIngresado;

    do
    {
        Console.WriteLine("\nIngrese un número positivo (0 para salir):  ");
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
    // Solicitar la frase al usuario
    Console.WriteLine("\nIngrese una frase: ");
    string frase = Console.ReadLine();

    // Contar palabras
    int contadorPalabras = 1;
    int i = 0;
    while (i < frase.Length)
    {
        if (char.IsWhiteSpace(frase[i]))
        {
            contadorPalabras++;
        }
        i++;
    }

    // Contar vocales
    int contadorVocales = 0;
    i = 0;
    while (i < frase.Length)
    {
        char letra = frase[i];
        if (esVocal(letra))
        {
            contadorVocales++;
        }
        i++;
    }

    // Mostrar resultados
    Console.WriteLine("\nNúmero de palabras: " + contadorPalabras);
    Console.WriteLine("Número de vocales: " + contadorVocales);
}

static bool esVocal(char letra)
{
    return "aeiouáéíóúüAEIOUÁÉÍÓÚÜ".IndexOf(letra) != -1;
}


static void Ejercicio4()
{
    Console.WriteLine("\nIngrese una palabra: ");
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
}
menu();