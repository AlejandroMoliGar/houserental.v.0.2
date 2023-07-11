using Newtonsoft.Json;
using System.IO;

public class Vendedor
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public decimal SquareMeters { get; set; }
    public int NumberOfRooms { get; set; }
    public bool Furnished { get; set; }
    public bool FreeOfLien { get; set; }
    public string TypeProperty { get; set; }
    public string PaymentType { get; set; }
    public string VendorName { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }

    public void PublishHouseForVent(){

        Console.WriteLine("\n¡Publicar una Casa para Renta!");

        Console.Write("Precio: ");
        decimal Price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ubicacion: ");
        string Location = Console.ReadLine();

        Console.Write("Metros cuadrados: ");
        decimal SquareMeters = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Numero de habitaciones: ");
        int NumberOfRooms = Convert.ToInt32(Console.ReadLine());

        Console.Write("Amueblada (s/n): ");
        bool Furnished = Console.ReadLine().ToLower() == "s";

        Console.Write("inmueble libre de garvamen (s/n): ");
        bool FreeOfLien = Console.ReadLine().ToLower() == "s";

        Console.Write("Tipo de Propiedad: ");
        string TypeProperty = Console.ReadLine();

        Console.Write("Tipo de Pago: ");
        string PaymentType = Console.ReadLine();

        Console.Write("Nombre del vendedor: ");
        string VendorName = Console.ReadLine();

        Console.Write("Numero de Telefono: ");
        int PhoneNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Correo Electronico: ");
        string Email = Console.ReadLine();

        Console.Write("Descripcion: ");
        string Description = Console.ReadLine();

        Console.Write("Fotos: ");
        string Photo = Console.ReadLine();

        Console.WriteLine("¡Casa publicada exitosamente para Venta!");

        var Houserental = new
        {
            Price = Price,
            Location = Location ,
            SquareMeters = SquareMeters,
            NumberOfRooms = NumberOfRooms,
            Furnished = Furnished,
            FreeOfLien = FreeOfLien,
            TypeProperty = TypeProperty,
            PaymentType = PaymentType,
            VendorName = VendorName,
            PhoneNumber = PhoneNumber,
            Email = Email,
            Description = Description,
            Photo = Photo
        };

       // Serializar el objeto a formato JSON
        string jsonData = JsonConvert.SerializeObject(Houserental, Formatting.Indented);

        Console.WriteLine("Datos en formato JSON:");
        Console.WriteLine(jsonData);

        // Llamar al método para guardar el JSON
        GuardarJson(jsonData);
    }

    public static void GuardarJson(string jsonData)
    {
        try
        {
            // Obtener el directorio actual
            string currentDirectory = Directory.GetCurrentDirectory();

            // Crear un nuevo archivo de texto
            string filePath = Path.Combine(currentDirectory, "HouseForSale.json");

            // Guardar el JSON en el archivo
            File.AppendAllText(filePath, jsonData + Environment.NewLine);

            Console.WriteLine("Los datos se han guardado correctamente en el archivo .json.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar los datos: " + ex.Message);
        }
    }

}