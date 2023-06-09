using System;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al Sistema de Búsqueda de Inmuebles!");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nPor favor, elija una opción:");
                Console.WriteLine("0. Soy Administrador");
                Console.WriteLine("1. Soy Arrendador");
                Console.WriteLine("2. Soy Arrendatario");
                Console.WriteLine("3. Soy Vendedor");
                Console.WriteLine("4. Soy Comprador");
                Console.WriteLine("5. Salir");

                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Administrador administrador = new Administrador();
                        administrador.UserAdmin();
                        break;
                    case "1":
                        Arendador arendador = new Arendador();
                        arendador.PublishHouseForRent();
                     case "2":
                         Arrendatario arrendatario = new Arrendatario();
                        arrendatario.PublishHouseForRent();
                        break;
                    case "3":
                        Vendedor vendedor = new Vendedor();
                        vendedor.PublishHouseForSale();
                        break;
                    case "4":
                        Comprador comprador = new Comprador();
                        comprador.BuscarInmuebleVenta();
                       break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
                        break;
                }
            }

            Console.WriteLine("¡Gracias por usar el Sistema de Búsqueda de Inmuebles! ¡Hasta luego!");
        }
    }
}
