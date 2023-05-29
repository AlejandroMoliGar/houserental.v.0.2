using Newtonsoft.Json;
using Newtonsoft.Json;
using System.IO;

public class Vendedor
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public int SquareMeters  { get; set; }
    public decimal NumberOfRooms { get; set; }
    public int Furnished { get; set; }
    public bool FreeGavamen { get; set; }
    public decimal PropertyType { get; set; }
    public decimal paymenttype { get; set; }
    public bool SellerName { get; set; }
    public bool PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Description { get; set; }
    public string Photos { get; set; }

    public void PublishHouseForRent(){

        Console.WriteLine("\n¡Publicar una Casa para Venta!");

        Console.Write("Precio: ");
        decimal Price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ubicacion: ");
        string Location = Console.ReadLine();

        Console.Write("Metros Cuadrados: ");
        int SquareMeters = Convert.ToInt32(Console.ReadLine());

        Console.Write("Numero de habitaciones: ");
        decimal NumberOfRooms = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Amueblado (s/n): ");
        int Furnished = Convert.ToInt32(Console.ReadLine());

        Console.Write("Campo libre gavmen: ");
        bool FreeGavamen = Console.ReadLine().ToLower() == "s";

        Console.Write("Tipo de propiedad: ");
        decimal PropertyType = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Tipo de pago: ");
        string paymenttype = Console.ReadLine();

        Console.Write("Nombre del vendedor ");
        bool SellerName = Console.ReadLine().ToLower() == "s";

        CConsole.Write("Numero de Telefono: ");
        int PhoneNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Correo electronico: ");
        string Email = Console.ReadLine();

        Console.Write("Descripcion: ");
        int Description = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fotografias: ");
        string Photos = Console.ReadLine();

    {
        Console.WriteLine("\n¡Buscar un Inmueble en Venta!");

        
        try
        {
            // Leer el archivo JSON
            string jsonData = File.ReadAllText(filePath);

            // Deserializar el JSON en una lista de objetos Vendedor
            var houseRentalList = JsonConvert.DeserializeObject<List<Vendedor>>(jsonData);

            // Acceder a los objetos y sus propiedades
            foreach (var houseRental in houseRentalList)
            {
                Console.WriteLine("Datos obtenidos del archivo:");
                Console.WriteLine($"Precio: {houseRental.Price}");
                Console.WriteLine($"Ubicación: {houseRental.Location}");
                Console.WriteLine($"Metros cuadrados:{houseRental.SquareMeters}");
                Console.WriteLine($"Numero de habitaciones: {houseRental.NumberOfRooms}");
                Console.WriteLine($"Amueblado: {houseRental.Furnished}");
                Console.WriteLine($"Campo libre gravamen: {houseRental.FreeGavamen}");
                Console.WriteLine($"Tipo de propiedad: {houseRental.PropertyType}");
                Console.WriteLine($"Tipo de pago: {houseRental.paymenttype}");
                Console.WriteLine($"Nombre vendedor: {houseRental.SellerName}");
                Console.WriteLine($"Telefono: {houseRental.PhoneNumber}");
                Console.WriteLine($"Correo electronico: {houseRental.Email}");
                Console.WriteLine($"Descripcion: {houseRental.Description}");
                Console.WriteLine($"Fotografía: {houseRental.Photo}");
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
        }
    }
}
