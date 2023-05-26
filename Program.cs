using System;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al Sistema de Búsqueda de Inmuebles!");

            Administrador administrador = new Administrador();
            administrador.RegistrarAdministrador();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nPor favor, elija una opción:");
                Console.WriteLine("1. Soy Arendador");
                Console.WriteLine("2. Soy Arrendatario");
                Console.WriteLine("3. Soy Vendedor");
                Console.WriteLine("4. Soy Comprador");
                Console.WriteLine("5. Salir");

                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Arendador arendador = new Arendador();
                        arendador.PublishHouseForRent();
                        break;
                    case "2":
                        Arendatario arendatario = new Arendatario();
                        arendatario.BuscarInmuebleRenta();
                        break;
                    case "3":
                        Vendedor vendedor = new Vendedor();
                        vendedor.PublishHouseForVent();
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

    class Administrador
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public void RegistrarAdministrador()
        {
            Console.WriteLine("¡Registro de Administrador!");

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            Telefono = Console.ReadLine();

            Console.Write("Correo Electrónico: ");
            CorreoElectronico = Console.ReadLine();

            Console.WriteLine("¡Registro exitoso!");
        }
    }


    

    class Comprador
    {
        public void BuscarInmuebleVenta()
        {
            Console.WriteLine("\n¡Buscar un Inmueble en Venta!");

            // Capturar los criterios de búsqueda

            Console.WriteLine("¡Resultados de la búsqueda!");
            // Mostrar los resultados encontrados
        }
    }

    class CasaVenta
    {
        public decimal Precio { get; set; }
        public string Ubicacion { get; set; }

        // Otros atributos de la casa para venta
    }
}