using Newtonsoft.Json;
using System.IO;

public class Administrador
{
    public string Name { get; set; }
    public long PhoneNumber { get; set; } // Cambiado a long para permitir 10 dígitos
    public string Email { get; set; }

    public void UserAdmin()
    {
        Console.WriteLine("Regístrate como Administrador!");

        Console.Write("Nombre del Administrador: ");
        string Name = Console.ReadLine();

        Console.Write("Número de Teléfono: ");
        long PhoneNumber = Convert.ToInt64(Console.ReadLine()); // Cambiado a long

        Console.Write("Correo Electrónico: ");
        string Email = Console.ReadLine();

        Console.WriteLine("¡Te has registrado con éxito!");

        var admin = new
        {
            Name = Name,
            PhoneNumber = PhoneNumber,
            Email = Email
        };

        // Serializar el objeto a formato JSON
        string jsonData = JsonConvert.SerializeObject(admin, Formatting.Indented);

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
            string filePath = Path.Combine(currentDirectory, "Administrador.json");

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
