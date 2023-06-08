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
        if (Price < 0)
        {
            Console.WriteLine("El precio ingresado no es válido. Debe ser un valor positivo.");
        }


        Console.Write("Ubicacion: ");
        string Location = string.Empty;
        while (string.IsNullOrEmpty(Location))
        {
            Console.Write("Ubicacion: ");
            Location = Console.ReadLine();
        }


        int NumberOfRooms = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Numero de habitaciones: ");
            string inputn = Console.ReadLine();
    
        if (int.TryParse(inputn, out int result))
        {
        NumberOfRooms = result;
        validInput = true;
        }
        else
        {
        Console.WriteLine("Entrada no válida. Introduce un número entero válido.");
        }
        }

        decimal Deposit = 0;
        bool valiInput = false;

        while (!valiInput)
        {
        Console.Write("Deposito: ");
        string inputn = Console.ReadLine();
    
        if (decimal.TryParse(inputn, out decimal result))
        {
        Deposit = result;
        valiInput = true;
        }
        else
        {
        Console.WriteLine("Entrada no válida. Introduce un valor decimal válido.");
        }
        }


        int MinimumContractDuration = 0;
        bool validInpu = false;

        while (!validInpu)
        {
        Console.Write("Duración mínima del contrato (en meses): ");
        string inputn = Console.ReadLine();

        if (int.TryParse(inputn, out int result))
        {
           MinimumContractDuration = result;
           validInpu = true;
        }
        else
       {
          Console.WriteLine("Entrada no válida. Introduce un número entero válido.");
       }
       }

        Console.Write("Contrato Exclusivo (s/n): ");
        string input = Console.ReadLine().ToLower();

        bool ExclusiveContract = false;
        if (input == "s" || input == "si" || input == "sí" || input == "yes")
        {
             ExclusiveContract = true;
        }
        else if (input == "n" || input == "no" || input == "nope")
        {
             ExclusiveContract = false;
        }
             else
        {
         Console.WriteLine("Entrada no válida. Se asumirá que no es un contrato exclusivo.");
        }
        


        decimal SquareMeters = 0;
        bool validinput = false;

        while (!validinput)
        {
        Console.Write("Metros cuadrados: ");
        string inputn = Console.ReadLine();

        if (decimal.TryParse(inputn, out decimal result))
        {
             SquareMeters = result;
             validinput = true;
        }
        else
        {
             Console.WriteLine("Entrada no válida. Introduce un valor decimal válido.");
        }
        } 

    

        Console.Write("incluye servicios (s/n): ");
        string inputn = Console.ReadLine().ToLower();

        string IncludedServices = string.Empty;

        if (inputn == "s" || inputn == "n")
        {
            IncludedServices = inputn;
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, introduce 's' o 'n'.");
    
        }

        Console.Write("Amueblada (s/n): ");
        bool Furnished;
        string inpu = Console.ReadLine().ToLower();

        while (inpu != "s" && inpu != "n")
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese 's' para sí o 'n' para no.");
            Console.Write("Amueblada (s/n): ");
            inpu = Console.ReadLine().ToLower();
        }

        Furnished = inpu == "s";



        Console.Write("Aceptación de mascotas (s/n): ");
        bool PetsAllowed;
        string imput = Console.ReadLine().ToLower();

        while (imput != "s" && imput != "n")
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese 's' para sí o 'n' para no.");
            Console.Write("Aceptación de mascotas (s/n): ");
            imput = Console.ReadLine().ToLower();
        }

        PetsAllowed = imput == "s";

        

        Console.Write("Nombre del Arrendador: ");
        string LandlordName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(LandlordName))
        {
            Console.WriteLine("Nombre inválido. Por favor, ingrese un nombre válido.");
            Console.Write("Nombre del Arrendador: ");
            LandlordName = Console.ReadLine();
        }

        Console.Write("Número de Teléfono: ");
        int PhoneNumber;

        while (!int.TryParse(Console.ReadLine(), out PhoneNumber))
        {
            Console.WriteLine("Número de Teléfono inválido. Por favor, ingrese un número válido.");
            Console.Write("Número de Teléfono: ");
        }
        
        
        Console.Write("Correo Electrónico: ");
        string Email = Console.ReadLine();

        while (!IsValidEmail(Email))
        {
            Console.WriteLine("Correo Electrónico inválido. Por favor, ingrese un correo electrónico válido.");
            Console.Write("Correo Electrónico: ");
            Email = Console.ReadLine();
        }

        static bool IsValidEmail(string email)
        {
            try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
            catch
        {
            return false;
        }
        }

        Console.Write("Descripción: ");
        string Description = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(Description))
        {
            Console.WriteLine("Descripción inválida. Por favor, ingrese una descripción válida.");
            Console.Write("Descripción: ");
            Description = Console.ReadLine();
        }

       Console.Write("Fotos: ");
       string Photo = Console.ReadLine();

       while (string.IsNullOrWhiteSpace(Photo))
       {
            Console.WriteLine("Debe proporcionar al menos una foto. Por favor, ingrese una foto válida.");
            Console.Write("Fotos: ");
            Photo = Console.ReadLine();
        }
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
