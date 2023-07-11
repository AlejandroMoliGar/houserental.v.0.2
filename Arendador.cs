using Newtonsoft.Json;
using System.IO;

public class Arendador
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public int NumberOfRooms { get; set; }
    public decimal Deposit { get; set; }
    public int MinimumContractDuration { get; set; }
    public bool ExclusiveContract { get; set; }
    public decimal SquareMeters { get; set; }
    public string IncludedServices { get; set; }
    public bool Furnished { get; set; }
    public bool PetsAllowed { get; set; }
    public string LandlordName { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }

    public void PublishHouseForRent(){

        Console.WriteLine("\n¡Publicar una Casa para Renta!");

        Console.Write("Precio: ");
        decimal Price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ubicacion: ");
        string Location = Console.ReadLine();

        Console.Write("Numero de habitaciones: ");
        int NumberOfRooms = Convert.ToInt32(Console.ReadLine());

        Console.Write("Deposito: ");
        decimal Deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Duración mínima del contrato (en meses): ");
        int MinimumContractDuration = Convert.ToInt32(Console.ReadLine());

        Console.Write("Contrato Exclusivo (s/n): ");
        bool ExclusiveContract = Console.ReadLine().ToLower() == "s";

        Console.Write("Metros cuadrados: ");
        decimal SquareMeters = Convert.ToDecimal(Console.ReadLine());

        Console.Write("incluye servicios (s/n): ");
        string IncludedServices = Console.ReadLine();

        Console.Write("Amueblada (s/n): ");
        bool Furnished = Console.ReadLine().ToLower() == "s";

        Console.Write("Aceptación de mascotas (s/n): ");
        bool PetsAllowed = Console.ReadLine().ToLower() == "s";

        Console.Write("Nombre del Arendador: ");
        string LandlordName = Console.ReadLine();

        Console.Write("Numero de Telefono: ");
        int PhoneNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Correo Electronico: ");
        string Email = Console.ReadLine();

        Console.Write("Descripcion: ");
        string Description = Console.ReadLine();

        Console.Write("Fotos: ");
        string Photo = Console.ReadLine();

        Console.WriteLine("¡Casa publicada exitosamente para renta!");

        var Houserental = new
        {
            Price = Price,
            Location = Location ,
            NumberOfRooms = NumberOfRooms,
            Deposit = Deposit,
            MinimumContractDuration = MinimumContractDuration,
            ExclusiveContract = ExclusiveContract,
            SquareMeters = SquareMeters,
            IncludedServices = IncludedServices,
            Furnished = Furnished,
            PetsAllowed = PetsAllowed,
            LandlordName = LandlordName,
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
            string filePath = Path.Combine(currentDirectory, "Houserental.json");

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