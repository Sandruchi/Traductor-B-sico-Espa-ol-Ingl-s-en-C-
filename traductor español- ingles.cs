using System;
using System.Collections.Generic;

class TraductorBasico
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"día", "day"},
        {"ojo", "eye"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"lugar", "place"},
        {"trabajo", "work"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del traductor...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese una frase en español: ");
        string frase = Console.ReadLine().ToLower();
        string[] palabras = frase.Split(' ');
        Console.WriteLine("\nTraducción parcial:");
        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra))
                Console.Write(diccionario[palabra] + " ");
            else
                Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en español: ");
        string esp = Console.ReadLine().ToLower();
        Console.Write("Ingrese su traducción en inglés: ");
        string eng = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, eng);
            Console.WriteLine("Palabra agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
