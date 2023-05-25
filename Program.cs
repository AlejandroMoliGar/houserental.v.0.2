using System;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al Sistema de Publicación de Casas para Renta!");
            Console.WriteLine("Por favor, elija una opción:");
            Console.WriteLine("1. Publicar una casa para renta");
            Console.WriteLine("2. Salir");

            bool exit = false;

            while (!exit)
            {
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Arendador arendador = new Arendador();
                        arendador.PublicarCasaRenta();
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
                        break;
                }
            }

            Console.WriteLine("Gracias por usar el Sistema de Publicación de Casas para Renta. ¡Hasta luego!");
        }
    }
}
